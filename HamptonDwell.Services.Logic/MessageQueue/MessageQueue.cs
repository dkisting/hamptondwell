using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Activation;
using EBS.HamptonDwell.Services.Data;


namespace EBS.HamptonDwell.Services.MessageQueues
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class MessageQueueService : IMessageQueueService
    {
        public MessageQueueResponse GetPendingMessageQueue(MessageQueueRequest request)
        {
            MessageQueueResponse response = new MessageQueueResponse();
            using (var context = new hamptondwellEntities())
            {
                List<MessageQueue> messageQueue = context.MessageQueues.
                    Where(u => u.Status_MessageQueueStatusID == request.Status_MessageQueueStatusID &&
                        u.Type_MessageQueueTypeID == request.Type_MessageQueueTypeID && u.Active == true).ToList();

                response.MessageQueueList = messageQueue.Select(a => new MessageQueueObject()
                {
                    MessageQueueId = a.MessageQueueID,
                    MessageBody = a.MessageBody,
                    Type_MessageQueueTypeID = a.Type_MessageQueueTypeID,
                    ModifiedByUserId = a.ModifiedBy_UserID,
                    CreatedByUserId = a.CreatedBy_UserID,
                    ModifiedOn = a.ModifiedOn,
                    CreatedOn = a.CreatedOn
                }).ToList();
                response.ResultSetCount = messageQueue.Count;
            }
            return response;


        }

        public MessageQueueResponse Save(MessageQueueRequest request)
        {
            MessageQueueResponse response = new MessageQueueResponse();
            using (var context = new hamptondwellEntities())
            {
                var messageQueue = context.MessageQueues.
                    Where(u => u.MessageQueueID == request.MessageQueueId).FirstOrDefault();

                messageQueue = messageQueue ?? new MessageQueue();

                messageQueue.ModifiedBy_UserID = request.ModifiedByUserId.Value;
                messageQueue.Active = request.Active ?? true;
                messageQueue.Status_MessageQueueStatusID = request.Status_MessageQueueStatusID;
                messageQueue.MessageResponse = request.MessageResponse;

                if (messageQueue.MessageQueueID == 0)
                {
                    messageQueue.CreatedOn = DateTime.UtcNow;
                    messageQueue.CreatedBy_UserID = request.CreatedByUserId ?? messageQueue.CreatedBy_UserID;
                    messageQueue.OccurredOn = request.OccurredOn;
                    messageQueue.Type_MessageQueueTypeID = request.Type_MessageQueueTypeID;
                    messageQueue.MessageBody = request.MessageBody;
                    
                }
                messageQueue.ModifiedOn = DateTime.UtcNow;

                if (messageQueue.MessageQueueID == 0)
                    context.AddObject("MessageQueues", messageQueue);

                context.SaveChanges();

                response.MessageQueue = new MessageQueueObject()
                {
                    MessageQueueId = messageQueue.MessageQueueID,
                    Active = messageQueue.Active,
                    MessageResponse = messageQueue.MessageResponse,
                    CreatedByUserId = messageQueue.CreatedBy_UserID,
                    MessageBody = messageQueue.MessageBody,
                    CreatedOn = messageQueue.CreatedOn,
                    ModifiedByUserId = messageQueue.ModifiedBy_UserID,
                    ModifiedOn = messageQueue.ModifiedOn,
                    Status_MessageQueueStatusID = messageQueue.Status_MessageQueueStatusID,
                    Type_MessageQueueTypeID = messageQueue.Type_MessageQueueTypeID
                }
                ;
            }
            return response;
        }
       
    }


}
