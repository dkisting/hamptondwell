using System;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Activation;
using EBS.HamptonDwell.Services.Data;


namespace EBS.HamptonDwell.Services.SystemConstants
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class SystemConstantService : ISystemConstantService
    {
        public SystemConstantResponse GetSystemConstantById(SystemConstantRequest request)
        {
            SystemConstantResponse response = new SystemConstantResponse();
            using (var context = new hamptondwellEntities())
            {
                var systemConstant = context.SystemConstants.
                    Where(u => u.SystemConstantID == request.SystemConstantId).FirstOrDefault();
                if (systemConstant != null)
                {
                    response.SystemConstant = new SystemConstantObject()
                                                  {
                                                      SystemConstantId = systemConstant.SystemConstantID,
                                                      Active = systemConstant.Active,
                                                      ConstantValue = systemConstant.ConstantValue,
                                                      CreatedByUserId = systemConstant.CreatedBy_UserID,
                                                      ModifiedByUserId = systemConstant.ModifiedBy_UserID,
                                                      Name = systemConstant.Name,
                                                      ModifiedOn = systemConstant.ModifiedOn,
                                                      CreatedOn = systemConstant.CreatedOn


                                                  }
                        ;
                }
            }
            return response;
        }
        public SystemConstantResponse GetSystemConstantByName(SystemConstantRequest request)
        {
            SystemConstantResponse response = new SystemConstantResponse();
            using (var context = new hamptondwellEntities())
            {
                var systemConstant = context.SystemConstants.
                    Where(u => u.Active == true && u.Name == request.Name).FirstOrDefault();
                if (systemConstant != null)
                {
                    response.SystemConstant = new SystemConstantObject()
                                                  {
                                                      SystemConstantId = systemConstant.SystemConstantID,
                                                      Active = systemConstant.Active,
                                                      ConstantValue = systemConstant.ConstantValue,
                                                      CreatedByUserId = systemConstant.CreatedBy_UserID,
                                                      ModifiedByUserId = systemConstant.ModifiedBy_UserID,
                                                      Name = systemConstant.Name,
                                                      ModifiedOn = systemConstant.ModifiedOn,
                                                      CreatedOn = systemConstant.CreatedOn
                                                  };

                }
            }
            return response;
        }
        public SystemConstantResponse Save(SystemConstantRequest request)
        {
            SystemConstantResponse response = new SystemConstantResponse();
            using (var context = new hamptondwellEntities())
            {
                var systemConstant = context.SystemConstants.
                    Where(u => u.SystemConstantID == request.SystemConstantId).FirstOrDefault();

                systemConstant = systemConstant ?? new SystemConstant();

                systemConstant.Name = request.Name;
                systemConstant.ConstantValue = request.ConstantValue;
                systemConstant.Active = request.Active;


                systemConstant.ModifiedBy_UserID = request.ModifiedByUserId;



                if (systemConstant.SystemConstantID == 0)
                {
                    systemConstant.CreatedOn = DateTime.UtcNow;
                    systemConstant.CreatedBy_UserID = request.CreateByUserId ?? systemConstant.CreatedBy_UserID;
                }
                systemConstant.ModifiedOn = DateTime.UtcNow;

                if (systemConstant.SystemConstantID == 0)
                    context.AddObject("SystemConstants", systemConstant);

                context.SaveChanges();

                response.SystemConstant = new SystemConstantObject()
                {
                    SystemConstantId = systemConstant.SystemConstantID,
                    Active = systemConstant.Active,
                    ConstantValue = systemConstant.ConstantValue,
                    CreatedByUserId = systemConstant.CreatedBy_UserID,
                    Name = systemConstant.Name,
                    CreatedOn = systemConstant.CreatedOn,
                    ModifiedByUserId = systemConstant.ModifiedBy_UserID,
                    ModifiedOn = systemConstant.ModifiedOn
                }
                ;
            }
            return response;
        }
        public SystemConstantResponse SaveSystemConstantByName(SystemConstantRequest request)
        {
            SystemConstantResponse response = new SystemConstantResponse();
            using (var context = new hamptondwellEntities())
            {
                var systemConstant = context.SystemConstants.
                    Where(u => u.Active == true && u.Name == request.Name).FirstOrDefault();

                systemConstant = systemConstant ?? new SystemConstant();

                
                systemConstant.ConstantValue = request.ConstantValue;
                systemConstant.ModifiedBy_UserID = request.ModifiedByUserId;
                systemConstant.ModifiedOn = DateTime.UtcNow;

      
                context.SaveChanges();

                response.SystemConstant = new SystemConstantObject()
                {
                    SystemConstantId = systemConstant.SystemConstantID,
                    Active = systemConstant.Active,
                    ConstantValue = systemConstant.ConstantValue,
                    CreatedByUserId = systemConstant.CreatedBy_UserID,
                    Name = systemConstant.Name,
                    CreatedOn = systemConstant.CreatedOn,
                    ModifiedByUserId = systemConstant.ModifiedBy_UserID,
                    ModifiedOn = systemConstant.ModifiedOn
                }
                ;
            }
            return response;
        }
        public SystemConstantResponse GetSystemConstantList(SystemConstantRequest request)
        {
            SystemConstantResponse response = new SystemConstantResponse();
            using (var context = new hamptondwellEntities())
            {
                var SystemConstant = (from a in context.SystemConstants.
                                   Where(
                                       a =>
                                       a.Active == request.Active &&
                                       (string.IsNullOrEmpty(request.FirstLetter) ||
                                        a.Name.StartsWith(request.FirstLetter)))
                                      select a);


                SystemConstant = GetListSort(SystemConstant, request);

                SystemConstant = SystemConstant.Skip(request.StartRowIndex).Take(request.MaximumRows);
                response.SystemConstantList = SystemConstant.Select(a => new SystemConstantObject
                {
                    SystemConstantId = a.SystemConstantID,
                    Name = a.Name,
                    ConstantValue = a.ConstantValue,
                    CreatedBy = (a.User1 != null ? a.User1.Email : string.Empty),
                    Active = a.Active,
                    ModifiedBy = (a.User != null ? a.User.Email : string.Empty),
                    ModifiedByUserId = a.ModifiedBy_UserID,
                    CreatedByUserId = a.CreatedBy_UserID,
                    ModifiedOn = a.ModifiedOn,
                    CreatedOn = a.CreatedOn
                }).ToList();
                response.ResultSetCount = GetSystemConstantListCount(request);
            }
            return response;
        }
        private IQueryable<SystemConstant> GetListSort(IQueryable<SystemConstant> systemConstantQuery, SystemConstantRequest request)
        {
            if (request.SortDirection == SortDirection.NONE)
            {
                request.SortDirection = SortDirection.ASC;
            }



            switch (request.SortBy)
            {
                default:
                case SortBy.Name:

                    if (request.SortDirection == SortDirection.ASC)
                    {
                        systemConstantQuery = systemConstantQuery.OrderBy(a => a.Name).ThenBy(a => a.ModifiedOn);
                    }
                    else
                    {
                        systemConstantQuery = systemConstantQuery.OrderByDescending(a => a.Name).ThenBy(a => a.ModifiedOn);
                    }

                    break;
            }

            return systemConstantQuery;

        }
        private int GetSystemConstantListCount(SystemConstantRequest request)
        {

            using (var context = new hamptondwellEntities())
            {

                var systemConstant = (from a in context.SystemConstants.
                                    Where(
                                        a =>
                                        a.Active == request.Active &&
                                        (string.IsNullOrEmpty(request.FirstLetter) ||
                                         a.Name.StartsWith(request.FirstLetter)))
                                      select a);
                return systemConstant.Count();

            }

        }

    }


}
