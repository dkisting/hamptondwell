using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Text;
using EBS.HamptonDwell.Services.Data;

namespace EBS.HamptonDwell.Services.VirtualPages
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class VirtualPageService : IVirtualPageService
    {
        public VirtualPageResponse GetVirtualPageById(VirtualPageRequest request)
        {
            VirtualPageResponse response = new VirtualPageResponse();
            using (var context = new hamptondwellEntities())
            {
                var virtualPage = context.VirtualPages.
                    Where(u => u.VirtualPageID == request.VirtualPageId).FirstOrDefault();

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
                if (virtualPage.VirtualPageKeywords.Count() > 0)
                {
                    foreach (VirtualPageKeyword keyword in virtualPage.VirtualPageKeywords
                        .Where(a => a.Active == true))
                    {
                        response.VirtualPage.Keywords += keyword.PageKeyword.Trim() + ";";
                    }
                }
                if (string.IsNullOrEmpty(response.VirtualPage.Keywords) == false)
                    response.VirtualPage.Keywords = response.VirtualPage.Keywords.Trim(';');
            }
            return response;
        }
        public VirtualPageResponse GetVirtualPageByPath(VirtualPageRequest request)
        {
            VirtualPageResponse response = new VirtualPageResponse();
            using (var context = new hamptondwellEntities())
            {
                var virtualPage = context.VirtualPages.
                    Where(u => u.Path == request.Path && u.Active == true).FirstOrDefault();

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
                    if (virtualPage.VirtualPageKeywords.Count() > 0)
                    {
                        foreach (VirtualPageKeyword keyword in virtualPage.VirtualPageKeywords
                            .Where(a => a.Active == true))
                        {
                            response.VirtualPage.Keywords += keyword.PageKeyword.Trim() + ";";
                        }
                    }
                    if (string.IsNullOrEmpty(response.VirtualPage.Keywords) == false)
                        response.VirtualPage.Keywords = response.VirtualPage.Keywords.Trim(';');
                }
            }
            return response;
        }
        public VirtualPageResponse Save(VirtualPageRequest request)
        {
            VirtualPageResponse response = new VirtualPageResponse();
            using (var context = new hamptondwellEntities())
            {
                var virtualPage = context.VirtualPages.
                    Where(u => u.VirtualPageID == request.VirtualPageId).FirstOrDefault();

                virtualPage = virtualPage ?? new VirtualPage();
                virtualPage.Path = request.Path;
                virtualPage.PageName = request.PageName;
                virtualPage.Active = request.Active;
                virtualPage.ModifiedBy_UserID = request.ModifiedByUserId;
                virtualPage.PageContent = request.PageContent;
                virtualPage.MemberOf_VirtualPageID = request.MemberOf;
                virtualPage.Template_VirtualPageID = request.PageTemplate;
                virtualPage.ModifiedOn = DateTime.UtcNow;
                virtualPage.MetaDescription = request.MetaDescription;
                virtualPage.PageTitle = request.PageTitle;
                virtualPage.IsTemplate = request.IsTemplate;

                if (virtualPage.VirtualPageID == 0)
                {
                    virtualPage.CreatedBy_UserID = request.CreatedByUserId;
                    virtualPage.CreatedOn = DateTime.UtcNow;

                    context.AddObject("VirtualPages", virtualPage);
                }

                if (virtualPage.IsTemplate == false)
                {
                    var rewriteRule = context.RewriteRules.Where(r => r.Active == true &&
                                                                      r.VirtualPage_VirtualPageID ==
                                                                      virtualPage.VirtualPageID).FirstOrDefault();

                    rewriteRule = rewriteRule ?? new RewriteRule()
                                                     {
                                                         Active = true,
                                                         CreatedOn = DateTime.UtcNow,
                                                         CreatedBy_UserID = request.CreatedByUserId,
                                                         ModifiedOn = DateTime.UtcNow,
                                                         ModifiedBy_UserID = request.ModifiedByUserId,
                                                         VirtualPage_VirtualPageID = virtualPage.VirtualPageID,
                                                         Rewrite = request.Path,
                                                         URL = virtualPage.PageName
                                                     };

                    if (rewriteRule.RewriteRuleID > 0)
                    {
                        rewriteRule.ModifiedBy_UserID = request.ModifiedByUserId;
                        rewriteRule.ModifiedOn = DateTime.UtcNow;
                        rewriteRule.URL = virtualPage.PageName;
                        rewriteRule.Rewrite = request.Path;
                        rewriteRule.Active = request.Active;
                    }
                    else
                    {
                        context.AddObject("RewriteRules", rewriteRule);
                    }
                }

                context.SaveChanges();




                response.VirtualPage = new VirtualPageObject()
                {
                    VirtualPageId = virtualPage.VirtualPageID,
                    PageName = virtualPage.PageName,
                    Active = virtualPage.Active.Value,
                    CreatedByUserId = virtualPage.CreatedBy_UserID.Value,
                    CreatedOn = virtualPage.CreatedOn.Value,
                    MetaDescription = virtualPage.MetaDescription,
                    PageTitle = virtualPage.PageTitle,
                    Path = virtualPage.Path,
                    PageContent = virtualPage.PageContent,
                    IsTemplate = virtualPage.IsTemplate ?? false,
                    MemberOf = virtualPage.MemberOf_VirtualPageID ?? 0,
                    ModifiedByUserId = virtualPage.ModifiedBy_UserID.Value,
                    Keywords = request.Keywords

                }
                ;
            }


            return response;
        }

        public VirtualPageResponse SaveKeywords(VirtualPageRequest request)
        {
            VirtualPageResponse response = new VirtualPageResponse();
            response.VirtualPage = new VirtualPageObject();
            response.VirtualPage.VirtualPageId = request.VirtualPageId;
            response.VirtualPage.Keywords = request.Keywords;

            using (var context = new hamptondwellEntities())
            {
                if (request.VirtualPageId > 0 && string.IsNullOrEmpty(request.Keywords))
                {
                    foreach (
                        VirtualPageKeyword keyword in
                            context.VirtualPageKeywords.Where(
                                k => k.VirtualPage_VirtualPageID == request.VirtualPageId
                                     && k.Active == true))
                    {
                        keyword.Active = false;
                        keyword.ModifiedBy_UserID = request.ModifiedByUserId.Value;
                        keyword.ModifiedOn = DateTime.UtcNow;

                    }
                }
                else
                {
                    List<VirtualPageKeyword> keywordList =
                        (from VirtualPageKeyword keyword in context.VirtualPageKeywords.Where(
                            k => k.VirtualPage_VirtualPageID == request.VirtualPageId
                                 && k.Active == true)
                         select keyword).ToList();

                    foreach (string item in request.Keywords.Split(';'))
                    {
                        if (keywordList.Find(k => k.PageKeyword.ToLower() == item.ToLower()) == null)
                        {
                            if (string.IsNullOrEmpty(item) || item == ";")
                                continue;

                            VirtualPageKeyword newKeyword = new VirtualPageKeyword()
                                                                {
                                                                    Active = true,
                                                                    CreatedOn = DateTime.UtcNow,
                                                                    ModifiedOn = DateTime.UtcNow,
                                                                    CreatedBy_UserID = request.CreatedByUserId.Value,
                                                                    ModifiedBy_UserID =
                                                                        request.ModifiedByUserId.Value,
                                                                    PageKeyword = item.Trim(),
                                                                    VirtualPage_VirtualPageID =
                                                                        request.VirtualPageId
                                                                };
                            context.AddObject("VirtualPageKeywords", newKeyword);

                        }
                    }
                    foreach (
                        VirtualPageKeyword keyword in
                            context.VirtualPageKeywords.Where(
                                k => k.VirtualPage_VirtualPageID == request.VirtualPageId
                                     && k.Active == true))
                    {
                        if (request.Keywords.Split(';').Contains(keyword.PageKeyword) == false)
                        {
                            keyword.Active = false;
                            keyword.ModifiedBy_UserID = request.ModifiedByUserId.Value;
                            keyword.ModifiedOn = DateTime.UtcNow;

                        }
                    }

                }
                context.SaveChanges();
            }

            return response;
        }

        public VirtualPageResponse GetVirtualPageTemplates(VirtualPageRequest request)
        {
            VirtualPageResponse response = new VirtualPageResponse();
            using (var context = new hamptondwellEntities())
            {
                var VirtualPage = (from a in context.VirtualPages.
                                   Where(
                                       a =>
                                       a.Active == request.Active &&
                                       a.IsTemplate == true)
                                   select a);

                VirtualPage = GetListSort(VirtualPage, request);

                VirtualPage = VirtualPage.Skip(request.StartRowIndex).Take(request.MaximumRows);
                response.VirtualPageList = VirtualPage.Select(a => new VirtualPageObject
                                                                       {
                                                                           VirtualPageId = a.VirtualPageID,
                                                                           PageName = a.PageName,
                                                                           Path = a.Path,
                                                                           CreatedByUserId = a.CreatedBy_UserID ?? 0,
                                                                           ModifiedByUserId = a.ModifiedBy_UserID ?? 0,
                                                                           CreatedOn = a.CreatedOn ?? DateTime.MinValue,
                                                                           ModifiedOn =
                                                                               a.ModifiedOn ?? DateTime.MinValue,
                                                                           IsTemplate = a.IsTemplate ?? false,
                                                                           MemberOf = a.MemberOf_VirtualPageID ?? 0,
                                                                           PageTemplate = a.Template_VirtualPageID ?? 0,
                                                                           PageContent = a.PageContent,
                                                                           Active = a.Active.Value

                                                                       }).ToList();
                response.VirtualPageList.Add(new VirtualPageObject() {VirtualPageId = 0, PageName = string.Empty});
                response.ResultSetCount = GetVirtualPageListCount(request);
            }
            return response;
        }
        public VirtualPageResponse GetVirtualPageParents(VirtualPageRequest request)
        {
            VirtualPageResponse response = new VirtualPageResponse();
            using (var context = new hamptondwellEntities())
            {
                var VirtualPage = (from a in context.VirtualPages.
                                   Where(
                                       a =>
                                       a.Active == request.Active &&
                                       a.IsTemplate == false &&
                                       a.MemberOf_VirtualPageID == null)
                                   select a);

                VirtualPage = GetListSort(VirtualPage, request);

                VirtualPage = VirtualPage.Skip(request.StartRowIndex).Take(request.MaximumRows);
                response.VirtualPageList = VirtualPage.Select(a => new VirtualPageObject
                {
                    VirtualPageId = a.VirtualPageID,
                    PageName = a.PageName,
                    Path = a.Path,
                    CreatedByUserId = a.CreatedBy_UserID ?? 0,
                    ModifiedByUserId = a.ModifiedBy_UserID ?? 0,
                    CreatedOn = a.CreatedOn ?? DateTime.MinValue,
                    ModifiedOn = a.ModifiedOn ?? DateTime.MinValue,
                    IsTemplate = a.IsTemplate ?? false,
                    MemberOf = a.MemberOf_VirtualPageID ?? 0,
                    PageTemplate = a.Template_VirtualPageID ?? 0,
                    PageContent = a.PageContent,
                    Active = a.Active.Value

                }).ToList();
                response.VirtualPageList.Add(new VirtualPageObject() { VirtualPageId = 0, PageName = string.Empty });
                response.ResultSetCount = GetVirtualPageListCount(request);
            }
            return response;
        }
        public VirtualPageResponse GetVirtualPageList(VirtualPageRequest request)
        {
            VirtualPageResponse response = new VirtualPageResponse();
            using (var context = new hamptondwellEntities())
            {
                var VirtualPage = (from a in context.VirtualPages.
                                   Where(
                                       a =>
                                       a.Active == request.Active &&
                                       (string.IsNullOrEmpty(request.FirstLetter) ||
                                        a.PageName.StartsWith(request.FirstLetter)))
                                   select a);

                VirtualPage = GetListSort(VirtualPage, request);

                VirtualPage = VirtualPage.Skip(request.StartRowIndex).Take(request.MaximumRows);
                response.VirtualPageList = VirtualPage.Select(a => new VirtualPageObject
                {
                    VirtualPageId = a.VirtualPageID,
                    PageName = a.PageName,
                    Path = a.Path,
                    CreatedByUserId = a.CreatedBy_UserID ?? 0,
                    ModifiedByUserId = a.ModifiedBy_UserID ?? 0,
                    CreatedOn = a.CreatedOn ?? DateTime.MinValue,
                    ModifiedOn = a.ModifiedOn ?? DateTime.MinValue,
                    IsTemplate = a.IsTemplate ?? false,
                    MemberOf = a.MemberOf_VirtualPageID ?? 0,
                    PageTemplate = a.Template_VirtualPageID ?? 0,
                    PageContent = a.PageContent,
                    Active = a.Active.Value

                }).ToList();
                response.ResultSetCount = GetVirtualPageListCount(request);
            }
            return response;
        }
        private IQueryable<VirtualPage> GetListSort(IQueryable<VirtualPage> virtualPageQuery, VirtualPageRequest request)
        {
            if (request.SortDirection == SortDirection.NONE)
            {
                request.SortDirection = SortDirection.ASC;
            }



            switch (request.SortBy)
            {
                default:
                case SortBy.PageName:

                    if (request.SortDirection == SortDirection.ASC)
                    {
                        virtualPageQuery = virtualPageQuery.OrderBy(a => a.PageName);
                    }
                    else
                    {
                        virtualPageQuery = virtualPageQuery.OrderByDescending(a => a.PageName);
                    }

                    break;
            }

            return virtualPageQuery;

        }
        private int GetVirtualPageListCount(VirtualPageRequest request)
        {

            using (var context = new hamptondwellEntities())
            {

                var virtualPage = (from a in context.VirtualPages.
                                    Where(
                                        a =>
                                        a.Active == request.Active &&
                                        (string.IsNullOrEmpty(request.FirstLetter) ||
                                         a.PageName.StartsWith(request.FirstLetter)))
                                   select a);
                return virtualPage.Count();

            }

        }

    }


}
