using System.Collections.Generic;
using EBS.HamptonDwell.Web.Logic.Services.SystemConstants;


namespace EBS.HamptonDwell.Web.Logic.Views.Admin
{
    public class SystemConstantEditModel
    {
        public IList<string> ErrorMessages { get; set; }
        public SystemConstantObject SystemConstantObject { get; set; }

        public SystemConstantEditModel()
        {
            ErrorMessages = new List<string>();
        }
    }

}
