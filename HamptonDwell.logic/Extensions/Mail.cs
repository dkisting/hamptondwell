
using System.Collections.Generic;
using System.Net.Mail;

namespace EBS.HamptonDwell.Web.Logic.Extensions
{
    public static class Mail
    {
        public static bool SendEmail(string Email,
            string subject, string body,
            string host, string mailAccount, string port, string user, string password, string domain,
            List<Attachment> attachmentCollection)
        {
            char[] dot = { ',' };
            string[] fields = Email.Split(dot, 6);

            try
            {
                SmtpClient client = new SmtpClient(host, int.Parse(port));

                if (string.IsNullOrEmpty(user) == false)
                {
                    client.Credentials = new System.Net.NetworkCredential(user, password, domain);
                }

                foreach (string recipient in fields)
                {
                    MailMessage message = new MailMessage();
                    message.IsBodyHtml = true;
                    message.Subject = subject.Replace("\r", " ").Replace("\n", " ");
                    message.Body = body;
                    message.From = new MailAddress(mailAccount);
                    message.CC.Add(recipient);

                    if (attachmentCollection != null)
                    {
                        foreach (Attachment attachment in attachmentCollection)
                            message.Attachments.Add(attachment);
                    }

                    client.Send(message);
                }
                return true;
            }
            catch (System.Exception e)
            {
                throw (e.InnerException ?? e);
            }
        }
    }
}
