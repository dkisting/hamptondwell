using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPages_Admin : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (TreeViewMainMenu != null)
        {
            TreeViewMainMenu.Visible = Context.User.Identity.IsAuthenticated;
            if (Request.ServerVariables["script_name"].IndexOf("Default.aspx") <= 0 && Context.User.Identity.IsAuthenticated == false)
                Response.Redirect("~/Default.aspx", true);
        }
    }
}
