using System.Collections.Generic;

namespace HamptonDwell.Web.Logic.Views.Models.Admin
{
    public class LoginModel
    {
        public IList<string> ErrorMessages { get; set; }


        public LoginModel()
        {
            ErrorMessages = new List<string>();
        }
    }
}
