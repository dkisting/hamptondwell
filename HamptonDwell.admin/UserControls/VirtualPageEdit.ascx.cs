using System;
using System.Web.UI.WebControls;
using EBS.HamptonDwell.Web.Logic.Presenters.Admin;
using HamptonDwell.Web.Logic.Views.Admin;
using HamptonDwell.Web.Logic.Views.Interfaces.Admin;
using WebFormsMvp.Web;


namespace EBS.HamptonDwell.Web.Admin
{
    public partial class VirtualPageEdit : MvpUserControl<VirtualPagesEditModel>, IVirtualPagesEditView
    {
        public event EventHandler<VirtualPagesEventArgs> ControlLoad;

        public void OnControlLoad(VirtualPagesEventArgs args)
        {
            var handler = ControlLoad;


            if (handler != null) handler(this, args);

            ddlMemberOf.DataSource = Model.VirtualPageParents;
            ddlMemberOf.DataTextField = "PageName";
            ddlMemberOf.DataValueField = "VirtualPageId";
            ddlMemberOf.DataBind();
            
           

            ddlPageTemplate.DataSource = Model.VirtualPageTemplates;
            ddlPageTemplate.DataTextField = "PageName";
            ddlPageTemplate.DataValueField = "VirtualPageId";
            ddlPageTemplate.DataBind();

            


        }

        public event EventHandler<VirtualPagesEventArgs> Save;

        public void OnSave(VirtualPagesEventArgs args)
        {
            var handler = Save;


            if (handler != null) handler(this, args);
        }



        public event EventHandler<VirtualPagesEventArgs> Delete;

        public void OnDelete(VirtualPagesEventArgs args)
        {
            var handler = Delete;


            if (handler != null) handler(this, args);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            int VirtualPageId = 0;
            int.TryParse(Request["VirtualPageId"], out VirtualPageId);

            virtualPageInput.Value = VirtualPageId.ToString();

            try
            {
                if (Page.IsPostBack == false)
                {


                    OnControlLoad(new VirtualPagesEventArgs() { VirtualPageId = VirtualPageId });

                    ListItem liPageTemplate = ddlPageTemplate.Items.FindByValue(Model.VirtualPagesObject.PageTemplate.ToString());
                    if (liPageTemplate != null)
                        liPageTemplate.Selected = true;

                    ListItem li = ddlMemberOf.Items.FindByValue(Model.VirtualPagesObject.MemberOf.ToString());
                    if (li != null)
                        li.Selected = true;
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
            int VirtualPageId = 0;
            int.TryParse(virtualPageInput.Value, out VirtualPageId);


            try
            {

                var args = new VirtualPagesEventArgs()
                {
                    VirtualPageId = VirtualPageId,
                    MemberOf = int.Parse(string.IsNullOrEmpty(ddlMemberOf.SelectedValue) ? "0" : ddlMemberOf.SelectedValue),
                    PageContent = PageContent.Text,
                    Path = txtPath.Value,
                    PageName = txtPageName.Value,
                    Active = chkActive.Checked,
                    IsTemplate = chkTemplate.Checked,
                    PageTemplate = int.Parse(string.IsNullOrEmpty(ddlPageTemplate.SelectedValue) ? "0" : ddlPageTemplate.SelectedValue),
                    Keywords = txtKeywords.Value,
                    MetaDescription = txtMetaDescription.Value,
                    PageTitle = txtPageTitle.Value
                };

           
                OnSave(args);

                virtualPageInput.Value = VirtualPageId.ToString();

                

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

            OnControlLoad(new VirtualPagesEventArgs() { VirtualPageId = VirtualPageId });
        }

        protected void SaveAndPublish_Click(object sender, EventArgs e)
        {
            int VirtualPageId = 0;
            int.TryParse(virtualPageInput.Value, out VirtualPageId);


            try
            {

                var args = new VirtualPagesEventArgs()
                {
                    VirtualPageId = VirtualPageId,
                    MemberOf = int.Parse(string.IsNullOrEmpty(ddlMemberOf.SelectedValue) ? "0" : ddlMemberOf.SelectedValue),
                    PageContent = PageContent.Text,
                    Path = txtPath.Value,
                    PageName = txtPageName.Value,
                    Active = chkActive.Checked,
                    IsTemplate = chkTemplate.Checked,
                    PageTemplate = int.Parse(string.IsNullOrEmpty(ddlPageTemplate.SelectedValue) ? "0" : ddlPageTemplate.SelectedValue),
                    Keywords = txtKeywords.Value,
                    MetaDescription = txtMetaDescription.Value,
                    PageTitle = txtPageTitle.Value,
                    Publish = true,
                    PublishOn = DateTime.UtcNow
                };


                OnSave(args);

                virtualPageInput.Value = VirtualPageId.ToString();



                spanMessage.Style.Remove("display");
                litMessage.Text = "Save Success and Page Queued for Publish";
            }
            catch (Exception ex)
            {
                messageTitle.Attributes.Remove("class");
                messageTitle.Attributes.Add("class", "alert_error");
                spanMessage.Style.Remove("display");
                litMessage.Text = ex.Message;
            }

            OnControlLoad(new VirtualPagesEventArgs() { VirtualPageId = VirtualPageId });
        }
    }
}