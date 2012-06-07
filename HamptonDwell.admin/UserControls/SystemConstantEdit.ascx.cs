using System;
using EBS.HamptonDwell.Web.Logic.Views.Admin;
using EBS.HamptonDwell.Web.Logic.Views.Interfaces.Admin;
using WebFormsMvp.Web;


namespace EBS.HamptonDwell.Web.Admin
{
    public partial class SystemConstantEdit : MvpUserControl<SystemConstantEditModel>, ISystemConstantEdit
    {
        public event EventHandler<SystemConstantEventArgs> ControlLoad;
        public void OnControlLoad(SystemConstantEventArgs args)
        {
            var handler = ControlLoad;


            if (handler != null) handler(this, args);
        }
        public event EventHandler<SystemConstantEventArgs> Save;
        public void OnSave(SystemConstantEventArgs args)
        {
            var handler = Save;


            if (handler != null) handler(this, args);
        }
        public event EventHandler<SystemConstantEventArgs> Delete;
        public void OnDelete(SystemConstantEventArgs args)
        {
            var handler = Delete;


            if (handler != null) handler(this, args);
        }
        protected void Page_Load(object sender, EventArgs e)
        {

            int systemConstantId = 0;
            int.TryParse(Request["systemConstantId"], out systemConstantId);

            try
            {
                if (Page.IsPostBack == false)
                {

                    systemConstantIDInput.Value = systemConstantId.ToString();
                    OnControlLoad(new SystemConstantEventArgs() { SystemConstantId = systemConstantId });
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

            int systemConstantId = 0;
            int.TryParse(systemConstantIDInput.Value, out systemConstantId);
            try
            {

                var args = new SystemConstantEventArgs() { SystemConstantId = systemConstantId, ConstantValue = txtConstantValue.Value, Name = txtConstantName.Value, Active = chkActive.Checked, };


                OnSave(args);

                systemConstantIDInput.Value = Model.SystemConstantObject.SystemConstantId.ToString();

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


            //OnControlLoad(new SystemConstantEventArgs() { SystemConstantId = Model.SystemConstantObject.SystemConstantId });

        }
    }
}