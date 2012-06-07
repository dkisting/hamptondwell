using System.Collections.Generic;

namespace HamptonDwell.Web.Logic.Views.Models.Admin
{
    public class LogoutModel
    {
        public IList<string> ErrorMessages { get; set; }

        public LogoutModel()
        {
            ErrorMessages = new List<string>();
        }
    }
}
