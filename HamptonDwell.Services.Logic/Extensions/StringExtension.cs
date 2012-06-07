using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using EBS.HamptonDwell.Services.Data;
using EBS.HamptonDwell.Services.SystemConstants;
using EBS.HamptonDwell.Services.VirtualPages;

namespace EBS.HamptonDwell.Services.Extensions
{
    public static class StringExtension
    {
        /// <summary> 
        /// Removes all html tags from string and leaves only plain text 
        /// Removes content of <xml></xml> and <style></style> tags as aim to get text content not markup /meta data. 
        /// </summary> 
        /// <param name="input"></param> 
        /// <returns></returns> 
        public static string HtmlStrip(this string input)
        {
            input = Regex.Replace(input, "<style>(.|\n)*?</style>", string.Empty);
            input = Regex.Replace(input, @"<xml>(.|\n)*?</xml>", string.Empty); // remove all <xml></xml> tags and anything inbetween.   
            input = Regex.Replace(input, @"<(.|\n)*?>", string.Empty); // remove any tags but not there content "<p>bob<span> johnson</span></p>" becomes "bob johnson" 


            return input;
        }
        public static string ReplaceConstants(this string pageContent)
        {
            string pattern = @"\[(?<myMatch>([^\]])*)\]";
            Regex r = new Regex(pattern);
            MatchCollection m = r.Matches(pageContent);

            foreach (Match match in m)
            {
                string item = match.Groups["myMatch"].Value;

                string templateType = "";
                string templateValue;

                if (item.IndexOf('.') > 0)
                {
                    templateType = item.Substring(0, item.IndexOf('.'));
                    templateValue = item.Substring(item.IndexOf('.') + 1,
                                                   item.Length - item.IndexOf('.') - 1);
                }
                else
                    templateValue = item;


                switch (templateType.ToLower())
                {
                    case "constant":
                        pageContent = pageContent.Replace("[" + item + "]",
                                                          SystemConstantHelper.GetSystemConstantByName(
                                                              new SystemConstantRequest() {Name = templateValue}).
                                                              SystemConstant.ConstantValue);
                        break;
                    default:
                        break;


                }
            }
            return pageContent;
        }

        public static string ReplaceControls(this string pageContent)
        {
            string pattern = @"\[(?<myMatch>([^\]])*)\]";
            Regex r = new Regex(pattern);
            MatchCollection m = r.Matches(pageContent);

            foreach (Match match in m)
            {
                string item = match.Groups["myMatch"].Value;

                string templateType = "";
                string templateValue;

                if (item.IndexOf('.') > 0)
                {
                    templateType = item.Substring(0, item.IndexOf('.'));
                    templateValue = item.Substring(item.IndexOf('.') + 1,
                                                   item.Length - item.IndexOf('.') - 1);
                }
                else
                    templateValue = item;
                

                switch (templateType.ToLower())
                {
                    
                    case "control":
                        pageContent = pageContent.Replace("[" + item + "]", string.Empty);
                        break;
                    default:
                        break;

                }
            }
            return pageContent;
        }
        public static VirtualPageResponse VirtualPage(this string fileName)
        {
            VirtualPageResponse response = new VirtualPageResponse();

            fileName = fileName.Replace("_", "?");
            using (var context = new hamptondwellEntities())
            {
                var virtualPage = context.VirtualPages.
                    Where(u => fileName.Contains(u.Path) && u.Active == true).FirstOrDefault();

                if (virtualPage != null)
                {

                    response.VirtualPage = new VirtualPageObject()
                                               {
                                                   VirtualPageId = virtualPage.VirtualPageID,
                                                   PageName = virtualPage.PageName,
                                                   Path = virtualPage.Path,
                                                   CreatedByUserId = virtualPage.CreatedBy_UserID ?? 0,
                                                   ModifiedByUserId = virtualPage.ModifiedBy_UserID ?? 0,
                                                   CreatedOn = virtualPage.CreatedOn ?? DateTime.MinValue,
                                                   ModifiedOn = virtualPage.ModifiedOn ?? DateTime.MinValue,
                                                   IsTemplate = virtualPage.IsTemplate ?? false,
                                                   MemberOf = virtualPage.MemberOf_VirtualPageID ?? 0,
                                                   PageTemplate = virtualPage.Template_VirtualPageID ?? 0,
                                                   PageContent = virtualPage.PageContent,
                                                   Active = virtualPage.Active ?? true,
                                                   MetaDescription = virtualPage.MetaDescription,
                                                   PageTitle = virtualPage.PageTitle,

                                               }
                        ;

                }
                response.VirtualPage = response.VirtualPage ?? new VirtualPageObject() { PageName = fileName, Path = fileName, PageTitle = fileName };
            }
            return response;
        }
    }
}
