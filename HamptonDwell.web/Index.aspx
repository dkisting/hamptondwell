<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/MasterPage.master" %>

<%@ Register Src="UserControls/FrontEndHomeController.ascx" TagName="Index" TagPrefix="uc1" %>
<script runat="server">
    protected void Page_Load(object sender, EventArgs e)
    {
        Index1.PreRender += new EventHandler(WebUserControl11_PreRender);
    }

    void WebUserControl11_PreRender(object sender, EventArgs e)
    {
        Header.Title = Index1.PageTitle;

        HtmlMeta metaTag = new HtmlMeta();

        metaTag.Name = "keywords";

        if (Index1.Keywords != null)
            metaTag.Content = Index1.Keywords;

        Master.Page.Header.Controls.Add(metaTag);

        HtmlMeta metaDescription = new HtmlMeta();

        metaDescription.Name = "description";

        if (Index1.MetaDescription != null)
            metaDescription.Content = Index1.MetaDescription;

        Master.Page.Header.Controls.Add(metaDescription);

    } 

</script>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <uc1:Index ID="Index1" runat="server" />
</asp:Content>
