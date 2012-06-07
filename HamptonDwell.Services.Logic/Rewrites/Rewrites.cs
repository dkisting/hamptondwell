using System;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Activation;
using EBS.HamptonDwell.Services.Data;


namespace EBS.HamptonDwell.Services.RewriteRules
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class RewriteRuleService : IRewriteRuleService
    {
        public RewriteRuleResponse GetRewriteRuleByUrl(RewriteRuleRequest request)
        {
            RewriteRuleResponse response = new RewriteRuleResponse();
            using (var context = new hamptondwellEntities())
            {
                var rewrite = context.RewriteRules.
                    Where(u => u.URL == request.Url && u.Active == true).FirstOrDefault();
                if (rewrite != null)
                {
                    response.RewriteRule = new RewriteRuleObject()
                                                  {
                                                      RewriteRuleId = rewrite.RewriteRuleID,
                                                      Active = rewrite.Active ?? true,
                                                      CreatedByUserId = rewrite.CreatedBy_UserID ?? 0,
                                                      ModifiedByUserId = rewrite.ModifiedBy_UserID ?? 0,
                                                      ModifiedOn = rewrite.ModifiedOn ?? DateTime.MinValue,
                                                      CreatedOn = rewrite.CreatedOn ?? DateTime.MinValue,
                                                      Rewrite = rewrite.Rewrite,
                                                      Url = rewrite.URL
                                                  }
                        ;
                }
            }
            return response;
        }
        
    

    }


}
