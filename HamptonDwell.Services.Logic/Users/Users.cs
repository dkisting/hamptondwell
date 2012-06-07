using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Text;
using EBS.HamptonDwell.Services.Data;

namespace EBS.HamptonDwell.Services.Users
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class UserService : IUserService
    {
        public UserResponse GetUserById(UserRequest request)
        {
            UserResponse response = new UserResponse();
            using (var context = new hamptondwellEntities())
            {
                var user = context.Users.
                    Where(u => u.UserID == request.UserId).FirstOrDefault();

                response.User = new UserObject()
                {
                    UserId = user.UserID,
                    Active = user.Active,
                    Email = user.Email,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Password = user.Password,
                    CreatedByUserId = user.CreatedBy_UserID ?? 0,
                    ModifiedByUserId = user.ModifiedBy_UserID ?? 0,
                    CreatedOn = user.CreatedOn ?? DateTime.MinValue,
                    ModifiedOn = user.ModifiedOn ?? DateTime.MinValue
                }
                ;
            }
            return response;
        }
        public UserResponse GetUser(UserRequest request)
        {
            UserResponse response = new UserResponse();
            
            using (var context = new hamptondwellEntities())
            {
                var user = context.Users.
                    Where(u =>
                        (string.IsNullOrEmpty(request.Email) == false && u.Email == request.Email) && u.Active == true).FirstOrDefault();

                if (user == null)
                    return response;

                response.User = new UserObject()
                {
                    UserId = user.UserID,
                    Active = user.Active,
                    Email = user.Email,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Password = user.Password,
                    CreatedByUserId = user.CreatedBy_UserID ?? 0,
                    ModifiedByUserId = user.ModifiedBy_UserID ?? 0,
                    CreatedOn = user.CreatedOn ?? DateTime.MinValue,
                    ModifiedOn = user.ModifiedOn ?? DateTime.MinValue
                }
                ;
            }
            return response;
        }
        public UserResponse Save(UserRequest request)
        {
            UserResponse response = new UserResponse();
            using (var context = new hamptondwellEntities())
            {
                var user = context.Users.
                    Where(u => u.UserID == request.UserId).FirstOrDefault();

                user = user ?? new User();

                user.Email = request.Email;
                user.Active = request.Active;
                user.FirstName = request.FirstName;
                user.LastName = request.LastName;
                user.ModifiedBy_UserID = request.ModifiedBy;
                user.ModifiedOn = DateTime.UtcNow;

                if (user.UserID == 0 || string.IsNullOrEmpty(request.Password) == false)
                {
                    user.Password = request.Password;
                }
                if (user.UserID == 0)
                {
                    user.CreatedBy_UserID = request.CreatedBy;
                    user.CreatedOn = DateTime.UtcNow;

                    context.AddObject("Users", user);
                }
                context.SaveChanges();

                response.User = new UserObject()
                {
                    UserId = user.UserID,
                    Active = user.Active,
                    Email = user.Email,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Password = user.Password,
                    CreatedOn = user.CreatedOn.Value,
                    ModifiedOn = user.ModifiedOn.Value
                }
                ;
            }
            return response;
        }
        public UserResponse GetUserList(UserRequest request)
        {
            UserResponse response = new UserResponse();
            using (var context = new hamptondwellEntities())
            {
                var User = (from a in context.Users.
                                   Where(
                                       a =>
                                       a.Active == request.Active &&
                                       (string.IsNullOrEmpty(request.FirstLetter) ||
                                        a.LastName.StartsWith(request.FirstLetter)) &&
                                       (string.IsNullOrEmpty(request.Email) || a.Email == request.Email))
                            select a);

                User = GetListSort(User, request);

                User = User.Skip(request.StartRowIndex).Take(request.MaximumRows);
                response.UserList = User.Select(a => new UserObject
                {
                    UserId = a.UserID,
                    FirstName = a.FirstName,
                    LastName = a.LastName,
                    Email = a.Email,
                    Active = a.Active,
                    Password = a.Password,
                    CreatedByUserId = a.CreatedBy_UserID ?? 0,
                    ModifiedByUserId = a.ModifiedBy_UserID ?? 0,
                    CreatedOn = a.CreatedOn ?? DateTime.MinValue,
                    ModifiedOn = a.ModifiedOn ?? DateTime.MinValue
                }).ToList();
                response.ResultSetCount = GetUserListCount(request);
            }
            return response;
        }
        private IQueryable<User> GetListSort(IQueryable<User> userQuery, UserRequest request)
        {
            if (request.SortDirection == SortDirection.NONE)
            {
                request.SortDirection = SortDirection.ASC;
            }



            switch (request.SortBy)
            {
                default:
                case SortBy.LastName:

                    if (request.SortDirection == SortDirection.ASC)
                    {
                        userQuery = userQuery.OrderBy(a => a.LastName).ThenBy(a => a.FirstName);
                    }
                    else
                    {
                        userQuery = userQuery.OrderByDescending(a => a.LastName).ThenBy(a => a.FirstName);
                    }

                    break;
            }

            return userQuery;

        }
        private int GetUserListCount(UserRequest request)
        {

            using (var context = new hamptondwellEntities())
            {

                var user = (from a in context.Users.
                                    Where(
                                        a =>
                                        a.Active == request.Active &&
                                        (string.IsNullOrEmpty(request.FirstLetter) ||
                                         a.LastName.StartsWith(request.FirstLetter)) &&
                                        (string.IsNullOrEmpty(request.Email) || a.Email == request.Email))
                            select a);
                return user.Count();

            }

        }

    }


}
