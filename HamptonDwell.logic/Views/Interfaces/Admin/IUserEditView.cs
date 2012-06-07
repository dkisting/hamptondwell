using System;
using HamptonDwell.Web.Logic.Presenters.Admin;
using HamptonDwell.Web.Logic.Views.Admin;
using WebFormsMvp;

namespace HamptonDwell.Web.Logic.Views.Interfaces.Admin
{
    public interface IUserEditView : IView<UserEditModel>
    {
        event EventHandler<UserEventArgs> ControlLoad;
        event EventHandler<UserEventArgs> Save;
        event EventHandler<UserEventArgs> Delete;
    }


}
