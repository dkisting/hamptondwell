using System;
using EBS.HamptonDwell.Web.Logic.Presenters.Admin;
using EBS.HamptonDwell.Web.Logic.Views.Admin;
using EBS.HamptonDwell.Web.Logic.Views.Interfaces.Admin;
using WebFormsMvp.Web;

namespace EBS.HamptonDwell.Web.Admin
{
    public partial class VirtualPageList : MvpUserControl<VirtualPageListModel>, IVirtualPageList
    {
        public event EventHandler<VirtualPagesEventArgs> ControlLoad;

        public void OnControlLoad(VirtualPagesEventArgs args)
        {
            var handler = ControlLoad;


            if (handler != null) handler(this, args);
          

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                int virtualPageId = 0;
                int.TryParse(Request["virtualPageId"], out virtualPageId);

                OnControlLoad(new VirtualPagesEventArgs() { VirtualPageId = virtualPageId });

            }
            DataBind();

        }
    }
    
}