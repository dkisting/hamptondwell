using System;
using System.Web;
using System.Web.Security;
using EBS.HamptonDwell.Web.Logic.Extensions;
using EBS.HamptonDwell.Web.Logic.Presenters;
using EBS.HamptonDwell.Web.Logic.Services.Users;
using EBS.HamptonDwell.Web.Logic.Views.Interfaces.Admin;
using HamptonDwell.Web.Logic.Presenters.Admin;



namespace EBS.HamptonDwell.Web.Admin
{
    public class LogoutPresenter : HamptonDwellPresenter<ILogoutView>
    {
        private readonly ILogoutView _view;
        readonly UserService _userService;
        public LogoutPresenter(ILogoutView view) : this(view, null) { }
        public LogoutPresenter(ILogoutView view, UserService userService)
            : base(view)
        {

            _view = view;
            _view.ControlLoad += new EventHandler<UserEventArgs>(_view_ControlLoad);
        }

        void _view_ControlLoad(object sender, UserEventArgs e)
        {
            FormsAuthentication.SignOut();
            HttpContext.Response.Redirect("default.aspx");
        }

     
    }
}
