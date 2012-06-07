
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace EBS.HamptonDwell.Services.RewriteRules
{
   [DataContract(Namespace = "Services.RewriteRules")]
    public class RewriteRuleResponse
    {
        [DataMember]
        public RewriteRuleObject RewriteRule { get; set; }
        [DataMember]
        public IList<RewriteRuleObject> RewriteRuleList { get; set; }

        [DataMember]
        public int ResultSetCount { get; set; }
    }

    public class RewriteRuleObject
    {
        [DataMember]
        public string Rewrite { get; set; }
        [DataMember]
        public string Url { get; set; }
        [DataMember]
        public int RewriteRuleId { get; set; }
    
        [DataMember]
        public string CreatedBy { get; set; }

        [DataMember]
        public string ModifiedBy { get; set; }

        [DataMember]
        public int CreatedByUserId { get; set; }

        [DataMember]
        public int ModifiedByUserId { get; set; }

        [DataMember]
        public DateTime CreatedOn { get; set; }

        [DataMember]
        public DateTime ModifiedOn { get; set; }

        [DataMember]
        public bool Active { get; set; }

    }
}
