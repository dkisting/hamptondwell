using System;

using EBS.HamptonDwell.Web.Logic.Views.Interfaces.Admin;
using HamptonDwell.Web.Logic.Presenters.Admin;
using HamptonDwell.Web.Logic.Views.Models.Admin;
using WebFormsMvp.Web;

namespace EBS.HamptonDwell.Web.Admin
{


    public partial class LoginControl : MvpUserControl<LoginModel>, ILoginView
    {
        public event EventHandler<UserEventArgs> ControlLoad;

        public void OnControlLoad(UserEventArgs args)
        {
            var handler = ControlLoad;


            if (handler != null) handler(this, args);


        }
        public event EventHandler<UserEventArgs> Login;

        public void OnLogin(UserEventArgs args)
        {
            var handler = Login;


            if (handler != null) handler(this, args);


        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                OnControlLoad(new UserEventArgs() { });
            }
        }
        protected  void Login_Click(object sender, EventArgs e)
        {
            UserEventArgs args = new UserEventArgs()
                                     {Active = true, Email = txtUserName.Text, Password = txtPassword.Text};

            try
            {
                OnLogin(args);
            }
            catch (Exception)
            {
                throw;
            }

        }


    }
}