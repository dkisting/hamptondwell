using System.ServiceModel;

namespace EBS.HamptonDwell.Services.MessageQueues
{

     [ServiceContract(
        Name = "MessageQueueService",
        Namespace = "urn:localhost/MessageQueue")]
    public interface IMessageQueueService
    {
        [OperationContract(
            Action = "GetMessageQueueRequest",
            ReplyAction = "GetMessageQueueResponse")]
        [FaultContract(
            typeof(MessageQueueFault),
            Name = "MessageQueueFault",
            Namespace = "MessageQueueFault",
            Action = "")]
        MessageQueueResponse GetPendingMessageQueue(MessageQueueRequest request);

        [OperationContract(
   Action = "SaveMessageQueue",
   ReplyAction = "SaveMessageQueue")]
        [FaultContract(
            typeof(MessageQueueFault),
            Name = "MessageQueueFault",
            Namespace = "MessageQueueFault",
            Action = "")]
        MessageQueueResponse Save(MessageQueueRequest request);


     
     
    }
}

