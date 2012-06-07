using System.ServiceModel;

namespace EBS.HamptonDwell.Services.RewriteRules
{

    [ServiceContract(
        Name = "RewriteRuleService",
        Namespace = "urn:localhost/RewriteRules")]
    public interface IRewriteRuleService
    {
        [OperationContract(
            Action = "GetRewriteRuleRequest",
            ReplyAction = "GetRewriteRuleResponse")]
        [FaultContract(
            typeof(RewriteRuleFault),
            Name = "RewriteRuleFault",
            Namespace = "RewriteRuleFault",
            Action = "")]
        RewriteRuleResponse GetRewriteRuleByUrl(RewriteRuleRequest request);

     
    }
}

