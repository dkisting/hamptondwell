using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.Caching;
using System.Web.Mail;
using EBS.HamptonDwell.Web.Admin;
using EBS.HamptonDwell.Web.Logic.Extensions;
using EBS.HamptonDwell.Web.Logic.Presenters.Admin;
using EBS.HamptonDwell.Web.Logic.Services.MessageQueues;

namespace EBS.HamptonDwell.Web.Logic.Domain
{
    public class SystemTimer
    {
        private static CacheItemRemovedCallback onRemove = new CacheItemRemovedCallback(RemovedCallback);

        private static Cache m_cache = HttpContext.Current.Cache;

        private static void RemovedCallback(String k, Object v, CacheItemRemovedReason r)
        {
            PerformTimerRefreshActions();
        }
        public static void PerformTimerRefreshActions()
        {
            bool EnableSystemTimer = false;
            bool.TryParse(SystemConstantHelper.GetSystemConstantValueByName("System Timer"), out EnableSystemTimer);

            if (EnableSystemTimer == false)
            {
                return;
            }

            int SystemTimerRefreshDuration = 120;
            int.TryParse(SystemConstantHelper.GetSystemConstantValueByName("System Timer Refresh Duration"),
                         out SystemTimerRefreshDuration);

            if (SystemTimerRefreshDuration == 0)
                return;

            DateTime dtExp = DateTime.Now.AddSeconds(SystemTimerRefreshDuration);

            ProcessHtmlMessageQueuePending();

            ProcessEmailMessageQueuePending();

            if (m_cache["LastTransactionRunTime"] != null)
                m_cache.Remove("LastTransactionRunTime");

            DateTime LastTransactionRunTime = DateTime.UtcNow;

            SystemConstantHelper.SaveSystemConstantValueByName(new SystemConstantEventArgs()
                                                                   {
                                                                       Name = "Last Transaction Run Time",
                                                                       ConstantValue = LastTransactionRunTime.ToString(),
                                                                       Active = true
                                                                   });

            m_cache.Insert("LastTransactionRunTime",
                LastTransactionRunTime.ToString(),
                null,
                dtExp,
                Cache.NoSlidingExpiration,
                CacheItemPriority.Normal,
                onRemove);
        }

        private static void ProcessEmailMessageQueuePending()
        {
            using (MessageQueueServiceClient messageClient = new MessageQueueServiceClient())
            {
                MessageQueueResponse queueResponse = new MessageQueueResponse();
                queueResponse = messageClient.GetPendingMessageQueue(new MessageQueueRequest()
                                                                         {

                                                                             Active = true,
                                                                             Type_MessageQueueTypeID = -1,
                                                                             Status_MessageQueueStatusID = -1

                                                                         });

                if (queueResponse != null && queueResponse.MessageQueueList != null && queueResponse.MessageQueueList.Count > 0)
                {
                    ContactFormMessageQueue contactFormMessageQueue = null;
                    foreach (MessageQueueObject response in queueResponse.MessageQueueList.OrderBy(s => s.MessageQueueId))
                    {
                        try
                        {
                            contactFormMessageQueue = JSONHelper.Deserialize<ContactFormMessageQueue>(response.MessageBody);

                            string toEmail = SystemConstantHelper.GetSystemConstantValueByName("Contact Email");
                            string fromEmail = SystemConstantHelper.GetSystemConstantValueByName("Contact Email");
                            string mailServer = SystemConstantHelper.GetSystemConstantValueByName("Mail Server");
                            string port = SystemConstantHelper.GetSystemConstantValueByName("Mail Port");
                            string user = SystemConstantHelper.GetSystemConstantValueByName("Mail User");
                            string password = SystemConstantHelper.GetSystemConstantValueByName("Mail Password");
                            string domain = SystemConstantHelper.GetSystemConstantValueByName("Mail Domain");

                            string subject = string.Format("A comment has been submitted from {0}",
                                                           contactFormMessageQueue.Name);

                            string body = string.Format("Email: {0}{1}Message: {2}{1}",
                                                       contactFormMessageQueue.Email,
                                                       "<p></p>",
                                                       contactFormMessageQueue.Message);

                       
                            Mail.SendEmail(toEmail, subject, body, mailServer, fromEmail, port, user, password, domain,
                                           new List<Attachment>());

                            messageClient.Save(new MessageQueueRequest()
                            {
                                Active = false,
                                Status_MessageQueueStatusID = -2,
                                MessageQueueId = response.MessageQueueId,
                                MessageResponse = string.Empty,
                                ModifiedByUserId = SystemConstantHelper.SystemUser
                            });


                        }
                        catch (Exception ex)
                        {

                            messageClient.Save(new MessageQueueRequest()
                            {
                                Active = false,
                                Status_MessageQueueStatusID = -3,
                                MessageQueueId = response.MessageQueueId,
                                MessageResponse = ex.Message,
                                ModifiedByUserId = SystemConstantHelper.SystemUser
                            });
                        }
                    }
                }
            }
        }
        private static void ProcessHtmlMessageQueuePending()
        {
            using (MessageQueueServiceClient messageClient = new MessageQueueServiceClient())
            {
                MessageQueueResponse queueResponse = new MessageQueueResponse();
                queueResponse = messageClient.GetPendingMessageQueue(new MessageQueueRequest()
                {

                    Active = true,
                    Type_MessageQueueTypeID = -2,
                    Status_MessageQueueStatusID = -1

                });

                if (queueResponse != null && queueResponse.MessageQueueList != null && queueResponse.MessageQueueList.Count > 0)
                {
                    string frontEndFileLocation = SystemConstantHelper.GetSystemConstantValueByName("Front End Map Path");
                    foreach (MessageQueueObject response in queueResponse.MessageQueueList.OrderBy(s => s.MessageQueueId))
                    {
                        MessageQueueList eventArgs =
                            JSONHelper.Deserialize<MessageQueueList>(response.MessageBody);

                        if (eventArgs != null)
                        {
                            if (eventArgs.MessageQueueEventArgsList != null)
                            {
                                try
                                {


                                    foreach (MessageQueueEventArgs args in eventArgs.MessageQueueEventArgsList)
                                    {
                                        ///download the images to the front end server
                                        if (args.ImageList != null)
                                        {
                                            foreach (string item in args.ImageList)
                                            {
                                                string newitem = item.Replace("\"", string.Empty);
                                                WebHelper.GetImage(args.ServerName + newitem,
                                                                   frontEndFileLocation + newitem);
                                            }
                                        }
                                        if (
                                            WebHelper.WriteHtmlPage(frontEndFileLocation + "\\HTML\\", args.PageName,
                                                                    args.ConvertedMessageBody) == false)
                                        {
                                            throw new Exception("Write Failed...");
                                        }
                                    }
                                }
                                catch (Exception ex)
                                {

                                    messageClient.Save(new MessageQueueRequest()
                                    {
                                        Active = false,
                                        Status_MessageQueueStatusID = -3,
                                        MessageQueueId = response.MessageQueueId,
                                        MessageResponse = ex.Message,
                                        ModifiedByUserId = SystemConstantHelper.SystemUser
                                    });
                                }

                            }

                        }
                        messageClient.Save(new MessageQueueRequest()
                                               {
                                                   Active = false,
                                                   Status_MessageQueueStatusID = -2,
                                                   MessageQueueId = response.MessageQueueId,
                                                   MessageResponse = string.Empty,
                                                   ModifiedByUserId = SystemConstantHelper.SystemUser
                                               });
                    }
                }

            }

        }
    }
}
