using System;
using HamptonDwell.Web.Logic.Presenters.Admin;
using HamptonDwell.Web.Logic.Views.Models.Admin;
using WebFormsMvp;

namespace EBS.HamptonDwell.Web.Logic.Views.Interfaces.Admin
{
    public interface ILogoutView : IView<LogoutModel>
    {
        event EventHandler<UserEventArgs> ControlLoad;
    }
}
