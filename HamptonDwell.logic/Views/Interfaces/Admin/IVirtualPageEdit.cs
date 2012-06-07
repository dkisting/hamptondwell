using System;
using EBS.HamptonDwell.Web.Logic.Presenters.Admin;
using HamptonDwell.Web.Logic.Views.Admin;
using WebFormsMvp;

namespace HamptonDwell.Web.Logic.Views.Interfaces.Admin
{
    public interface IVirtualPagesEditView : IView<VirtualPagesEditModel>
    {
        event EventHandler<VirtualPagesEventArgs> ControlLoad;
        event EventHandler<VirtualPagesEventArgs> Save;
        event EventHandler<VirtualPagesEventArgs> Delete;
    }


}
