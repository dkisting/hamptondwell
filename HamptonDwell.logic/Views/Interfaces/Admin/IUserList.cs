using System;
using EBS.HamptonDwell.Web.Logic.Views.Admin;
using HamptonDwell.Web.Logic.Presenters.Admin;
using WebFormsMvp;

namespace EBS.HamptonDwell.Web.Logic.Views.Interfaces.Admin
{
    public interface IUserList : IView<UserListModel>
    {
        event EventHandler<UserEventArgs> ControlLoad;
        
    }


}
