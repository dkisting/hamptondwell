using System;
using EBS.HamptonDwell.Web.Logic.Views.FrontEnd;
using HamptonDwell.Web.Logic.Presenters.FrontEnd;
using HamptonDwell.Web.Logic.Views.Interfaces.FrontEnd;
using WebFormsMvp.Web;

namespace EBS.HamptonDwell.Web.FrontEnd
{
    public partial class FrontEndHomeController : MvpUserControl<FrontEndHomeControllerModel>, IFrontEndHomeController
    {
        public event EventHandler<FrontEndHomeControllerEventArgs> ControlLoad;
        public void OnControlLoad(FrontEndHomeControllerEventArgs args)
        {
            var handler = ControlLoad;
            if (handler != null) handler(this, args);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                string pageName = GetFileBase(Request.ServerVariables["script_name"]) + (!string.IsNullOrEmpty(Request.ServerVariables["QUERY_STRING"]) ?
                "_" + Request.ServerVariables["QUERY_STRING"] : string.Empty);

                OnControlLoad(new FrontEndHomeControllerEventArgs() { PageName = pageName, HTMLDirectory = Server.MapPath("HTML")});

               
            }
        }
        public string PageTitle
        {
            get { return Model.PageTitle; }
        }
        public string MetaDescription
        {
            get { return Model.MetaDescription;  }
        }
        public string Keywords
        {
            get
            {
                string output = string.Empty;

                if (Model != null && Model.PageKeywords != null)
                {
                    foreach (string item in Model.PageKeywords)
                        output += item + ",";
                }
                return output.Trim(',');
            }
        }
        private string GetFileBase(string strFullPath)
        {
            char[] delimiters = { '/', '\\' };
            int nFileName = strFullPath.LastIndexOfAny(delimiters);
            if (nFileName < 0)
                return strFullPath;
            else
                return strFullPath.Substring(nFileName + 1);
        }
    }
}