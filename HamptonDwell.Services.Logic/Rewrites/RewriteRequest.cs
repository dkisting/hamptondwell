using System.Runtime.Serialization;


namespace EBS.HamptonDwell.Services.RewriteRules
{
    public class RewriteRuleRequest
    {
        [DataMember]
        public string Rewrite { get; set; }
        [DataMember]
        public string Url { get; set; }
        [DataMember]
        public int RewriteRuleId { get; set; }
        [DataMember]
        public bool Active { get; set; }

    }


}
