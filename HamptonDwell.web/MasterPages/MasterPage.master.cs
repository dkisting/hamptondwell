using System;

namespace EBS.HamptonDwell.Web.FrontEnd
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

 
        public string Title
        {
            set { pageTitle.Text = value; }
        }

        
    }
}