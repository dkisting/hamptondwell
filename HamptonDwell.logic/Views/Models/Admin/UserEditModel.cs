using System.Collections.Generic;
using EBS.HamptonDwell.Web.Logic.Services.Users;


namespace HamptonDwell.Web.Logic.Views.Admin
{
    public class UserEditModel
    {
        public IList<string> ErrorMessages { get; set; }
        public UserObject UserObject { get; set; }

        public UserEditModel()
        {
            ErrorMessages = new List<string>();
        }
    }

}
