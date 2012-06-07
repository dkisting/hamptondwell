using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EBS.HamptonDwell.Web.Logic.Presenters.Admin;
using HamptonDwell.Web.Logic.Presenters.Admin;
using HamptonDwell.Web.Logic.Views.Admin;
using HamptonDwell.Web.Logic.Views.Interfaces.Admin;
using WebFormsMvp.Web;


namespace EBS.HamptonDwell.Web.Admin
{
    public partial class UserEdit : MvpUserControl<UserEditModel>, IUserEditView
    {
        public event EventHandler<UserEventArgs> ControlLoad;

        public void OnControlLoad(UserEventArgs args)
        {
            var handler = ControlLoad;


            if (handler != null) handler(this, args);
        }

        public event EventHandler<UserEventArgs> Save;

        public void OnSave(UserEventArgs args)
        {
            var handler = Save;


            if (handler != null) handler(this, args);
        }

        public event EventHandler<UserEventArgs> Delete;

        public void OnDelete(UserEventArgs args)
        {
            var handler = Delete;


            if (handler != null) handler(this, args);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            int userId = 0;
            int.TryParse(Request["userId"], out userId);

            try
            {
                if (Page.IsPostBack == false)
                {

                    userIDInput.Value = userId.ToString();
                    OnControlLoad(new UserEventArgs() { UserId = userId });
                }
            }
            catch (Exception ex)
            {
                messageTitle.Attributes.Remove("class");
                messageTitle.Attributes.Add("class", "alert_error");
                spanMessage.Style.Remove("display");
                litMessage.Text = ex.Message;
            }




        }

        protected void Save_Click(object sender, EventArgs e)
        {
            int userId = 0;
            int.TryParse(userIDInput.Value, out userId);
            try
            {

                var args = new UserEventArgs()
                {
                    UserId = userId,

                    Active = chkActive.Checked,
                    FirstName = txtFirstName.Value,
                    LastName = txtLastName.Value,
                    Email = txtEmail.Value,
                    Password = txtPassword.Value

                };

                OnSave(args);

                userIDInput.Value = Model.UserObject.UserId.ToString();

                spanMessage.Style.Remove("display");
                litMessage.Text = "Save Success";
            }
            catch (Exception ex)
            {
                messageTitle.Attributes.Remove("class");
                messageTitle.Attributes.Add("class", "alert_error");
                spanMessage.Style.Remove("display");
                litMessage.Text = ex.Message;
            }

            OnControlLoad(new UserEventArgs() { UserId = userId });

        }
    }
}