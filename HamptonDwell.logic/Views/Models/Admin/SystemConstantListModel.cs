using System.Collections.Generic;
using EBS.HamptonDwell.Web.Logic.Services.SystemConstants;


namespace EBS.HamptonDwell.Web.Logic.Views.Admin
{
    public class SystemConstantListModel
    {
        public IList<string> ErrorMessages { get; set; }
        public List<SystemConstantObject> SystemConstantList { get; set; }

        public SystemConstantListModel()
        {
            ErrorMessages = new List<string>();
        }
    }

}
