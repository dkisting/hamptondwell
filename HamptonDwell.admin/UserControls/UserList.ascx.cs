using System;
using EBS.HamptonDwell.Web.Logic.Views.Admin;
using EBS.HamptonDwell.Web.Logic.Views.Interfaces.Admin;
using HamptonDwell.Web.Logic.Presenters.Admin;
using WebFormsMvp.Web;

namespace EBS.HamptonDwell.Web.Admin
{
    public partial class UserList : MvpUserControl<UserListModel>, IUserList
    {
        public event EventHandler<UserEventArgs> ControlLoad;

        public void OnControlLoad(UserEventArgs args)
        {
            var handler = ControlLoad;


            if (handler != null) handler(this, args);
   

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                int userId = 0;
                int.TryParse(Request["userId"], out userId);

                OnControlLoad(new UserEventArgs() { UserId = userId });

            }


        }
    }
}