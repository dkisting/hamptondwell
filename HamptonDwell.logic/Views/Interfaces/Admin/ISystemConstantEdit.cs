using System;
using EBS.HamptonDwell.Web.Admin;
using EBS.HamptonDwell.Web.Logic.Views.Admin;
using WebFormsMvp;

namespace EBS.HamptonDwell.Web.Logic.Views.Interfaces.Admin
{
    public interface ISystemConstantEdit : IView<SystemConstantEditModel>
    {
        event EventHandler<SystemConstantEventArgs> ControlLoad;
        event EventHandler<SystemConstantEventArgs> Save;
        event EventHandler<SystemConstantEventArgs> Delete;
    }


}
