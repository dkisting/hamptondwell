using System;
using EBS.HamptonDwell.Web.Logic.Views.Admin;
using EBS.HamptonDwell.Web.Logic.Views.Interfaces.Admin;
using WebFormsMvp.Web;

namespace EBS.HamptonDwell.Web.Admin
{
    public partial class SystemConstantList : MvpUserControl<SystemConstantListModel>, ISystemConstantList
    {
        public event EventHandler<SystemConstantEventArgs> ControlLoad;

        public void OnControlLoad(SystemConstantEventArgs args)
        {
            var handler = ControlLoad;


            if (handler != null) handler(this, args);
           

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                int systemConstantId = 0;
                int.TryParse(Request["systemConstantId"], out systemConstantId);

                OnControlLoad(new SystemConstantEventArgs() {SystemConstantId = systemConstantId});

            }


        }
    }
}