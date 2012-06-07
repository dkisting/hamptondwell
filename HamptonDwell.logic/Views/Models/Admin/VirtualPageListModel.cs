using System.Collections.Generic;
using EBS.HamptonDwell.Web.Logic.Services.VirtualPages;


namespace EBS.HamptonDwell.Web.Logic.Views.Admin
{
    public class VirtualPageListModel
    {
        public IList<string> ErrorMessages { get; set; }
        public List<VirtualPageObject> VirtualPageObjects { get; set; }

        public VirtualPageListModel()
        {
            ErrorMessages = new List<string>();
        }
    }

}
