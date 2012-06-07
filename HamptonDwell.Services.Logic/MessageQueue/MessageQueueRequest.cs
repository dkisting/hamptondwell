using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace EBS.HamptonDwell.Services.MessageQueues
{
    
    public class MessageQueueRequest
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
    [DataContract(Namespace = "ContactFormMessageQueue")]
    public class ContactFormMessageQueue
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string Message { get; set; }
    }
    [DataContract(Namespace = "SearchResultList")]
    public class SearchResultList
    {

        [DataMember]
        public List<SearchResult> SearchResults { get; set; }

        [DataMember]
        public decimal SearchDuration { get; set; }

        [DataMember]
        public string SearchCriteria { get; set; }

    }
    [DataContract(Namespace = "SearchCriteria")]
    public class SearchCriteriaObject
    {
        [DataMember]
        public string SearchCriteria { get; set; }

    }
    [DataContract(Namespace = "SearchResult")]
    public class SearchResult
    {

        [DataMember]
        public string PageName { get; set; }
        [DataMember]
        public string ModifiedOn { get; set; }
       
        [DataMember]
        public string BodyText { get; set; }

        [DataMember]
        public string PageTitle { get; set; }

    }
}
