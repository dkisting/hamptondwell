using System.Collections.Generic;
using EBS.HamptonDwell.Web.Logic.Services.VirtualPages;




namespace HamptonDwell.Web.Logic.Views.Admin
{
    public class VirtualPagesEditModel
    {
        public IList<string> ErrorMessages { get; set; }
        public VirtualPageObject VirtualPagesObject { get; set; }
        public List<VirtualPageObject> VirtualPageTemplates { get; set; }
        public List<VirtualPageObject> VirtualPageParents { get; set; }

        public VirtualPagesEditModel()
        {
            ErrorMessages = new List<string>();
        }
    }

}
