using System;
using EBS.HamptonDwell.Web.Admin;
using EBS.HamptonDwell.Web.Logic.Views.Admin;
using WebFormsMvp;

namespace EBS.HamptonDwell.Web.Logic.Views.Interfaces.Admin
{
    public interface ISystemConstantList : IView<SystemConstantListModel>
    {
        event EventHandler<SystemConstantEventArgs> ControlLoad;
        
    }


}
