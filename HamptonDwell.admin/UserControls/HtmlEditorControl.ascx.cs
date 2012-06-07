
namespace EBS.HamptonDwell.Web.Admin
{
    public partial class HTMLEditorControl : System.Web.UI.UserControl
    {

  

        private bool _IsRequired = false;
        public bool IsRequired
        {
            get
            {
                return _IsRequired;
            }
            set
            {
                _IsRequired = value;
            }
        }

        private string BaseUrl
        {
            get
            {
                string url = Request.Url.AbsoluteUri;
                int index = url.IndexOf(Request.ApplicationPath);

                string replaceUrl = url.Substring(0, index + Request.ApplicationPath.Length + 1);
                return replaceUrl;
            }
        }

        public string Text
        {
            set
            {

                Editor1.Text = value;
            }
            get
            {

                return Editor1.Text;
            }
        }

        protected void Page_Load(object sender, System.EventArgs e)
        {
        }


    }
}
