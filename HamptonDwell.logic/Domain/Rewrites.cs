

using System.Text.RegularExpressions;
using System.Web;
using EBS.HamptonDwell.Web.Logic.Services.RewriteRules;


namespace EBS.HamptonDwell.Web.Logic.Domain
{
    public class UrlRewriter
    {
     
        public UrlRewriter() { }

     
        private static bool IsMatch(string Path, out int RewriteRuleID)
        {
            Regex oReg;
            Match oMatch;
            RewriteRuleID = 0;

            RewriteRuleResponse response = new RewriteRuleResponse();
            using (RewriteRuleServiceClient client = new RewriteRuleServiceClient())
            {
                response = client.GetRewriteRuleByUrl(new RewriteRuleRequest()
                {
                    Url = Path
                });

                client.Close();
            }
            if (response != null && response.RewriteRule != null)
            {
                RewriteRuleID = response.RewriteRule.RewriteRuleId;
            }

            return RewriteRuleID > 0;
        }

        public static string GetSubstitution(string path)
        {

            Regex oReg;

            RewriteRuleResponse response = new RewriteRuleResponse();
            using (RewriteRuleServiceClient client = new RewriteRuleServiceClient())
            {
                response = client.GetRewriteRuleByUrl(new RewriteRuleRequest()
                {
                    Url = path
                });

                client.Close();
            }

            if (response != null && response.RewriteRule != null && response.RewriteRule.RewriteRuleId > 0)
            {
                oReg = new Regex(response.RewriteRule.Url);
                return oReg.Replace(path, response.RewriteRule.Rewrite);
            }



            return path;
        }
        public static void Process()
        {
       
            string _sub =
                UrlRewriter.GetSubstitution(HttpContext.Current.Request.Path);


            if (_sub.Length > 0)
            {
                HttpContext.Current.RewritePath(_sub);
            } else
            {
                HttpContext.Current.Response.Write(HttpContext.Current.Request.Path);
            }
        }

       
    }
}
