using System.Collections.Generic;
using EBS.HamptonDwell.Web.Logic.Services.Users;


namespace EBS.HamptonDwell.Web.Logic.Views.Admin
{
    public class UserListModel
    {
        public IList<string> ErrorMessages { get; set; }
        public List<UserObject> UserObjects { get; set; }

        public UserListModel()
        {
            ErrorMessages = new List<string>();
        }
    }

}
