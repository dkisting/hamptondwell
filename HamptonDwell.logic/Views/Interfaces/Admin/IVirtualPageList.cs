using System;
using EBS.HamptonDwell.Web.Logic.Presenters.Admin;
using EBS.HamptonDwell.Web.Logic.Views.Admin;
using WebFormsMvp;

namespace EBS.HamptonDwell.Web.Logic.Views.Interfaces.Admin
{
    public interface IVirtualPageList : IView<VirtualPageListModel>
    {
        event EventHandler<VirtualPagesEventArgs> ControlLoad;
        
    }


}
