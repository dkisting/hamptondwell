using System;

using EBS.HamptonDwell.Web.Logic.Views.Interfaces.Admin;
using HamptonDwell.Web.Logic.Presenters.Admin;
using HamptonDwell.Web.Logic.Views.Models.Admin;
using WebFormsMvp.Web;

namespace EBS.HamptonDwell.Web.Admin
{


    public partial class Logout : MvpUserControl<LogoutModel>, ILogoutView
    {
        public event EventHandler<UserEventArgs> ControlLoad;

        public void OnControlLoad(UserEventArgs args)
        {
            var handler = ControlLoad;


            if (handler != null) handler(this, args);


        }
     
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                OnControlLoad(new UserEventArgs() { });
            }
        }
      

    }
}