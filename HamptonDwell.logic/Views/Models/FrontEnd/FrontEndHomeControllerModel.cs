using System.Collections.Generic;


namespace EBS.HamptonDwell.Web.Logic.Views.FrontEnd
{
    public class FrontEndHomeControllerModel
    {
        public IList<string> ErrorMessages { get; set; }
        public string PageOutput { get; set; }
        public string MetaDescription { get; set; }
        public string PageTitle { get; set; }
        public IList<string> PageKeywords { get; set; } 

        public FrontEndHomeControllerModel()
        {
            ErrorMessages = new List<string>();
        }
    }

}
