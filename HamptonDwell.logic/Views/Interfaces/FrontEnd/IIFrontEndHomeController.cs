using System;
using EBS.HamptonDwell.Web.Logic.Views.Admin;
using EBS.HamptonDwell.Web.Logic.Views.FrontEnd;
using HamptonDwell.Web.Logic.Presenters.Admin;
using HamptonDwell.Web.Logic.Presenters.FrontEnd;
using WebFormsMvp;

namespace HamptonDwell.Web.Logic.Views.Interfaces.FrontEnd
{
    public interface IFrontEndHomeController : IView<FrontEndHomeControllerModel>
    {
        event EventHandler<FrontEndHomeControllerEventArgs> ControlLoad;
        
    }


}
