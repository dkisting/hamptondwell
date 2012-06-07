
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace EBS.HamptonDwell.Services.MessageQueues
{
   [DataContract(Namespace = "Services.MessageQueues")]
    public class MessageQueueResponse
    {
        [DataMember]
        public MessageQueueObject MessageQueue { get; set; }
        [DataMember]
        public IList<MessageQueueObject> MessageQueueList { get; set; }

        [DataMember]
        public int ResultSetCount { get; set; }
    }

    public class MessageQueueObject
    {
        [DataMember]
        public string MessageBody { get; set; }
        [DataMember]
        public string MessageResponse { get; set; }
        [DataMember]
        public int MessageQueueId { get; set; }
    
        [DataMember]
        public string CreatedBy { get; set; }

        [DataMember]
        public string ModifiedBy { get; set; }

        [DataMember]
        public int? CreatedByUserId { get; set; }

        [DataMember]
        public int Status_MessageQueueStatusID { get; set; }

        [DataMember]
        public int Type_MessageQueueTypeID { get; set; }

        [DataMember]
        public int? ModifiedByUserId { get; set; }

        [DataMember]
        public DateTime? OccurredOn { get; set; }

        [DataMember]
        public DateTime? CreatedOn { get; set; }

        [DataMember]
        public DateTime? ModifiedOn { get; set; }

        [DataMember]
        public bool? Active { get; set; }

    }
}
