<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Admin.master" %>

<%@ Register src="UserControls/UserEdit.ascx" tagname="UserEdit" tagprefix="uc1" %>

<script runat="server">

</script>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <uc1:UserEdit ID="UserEdit1" runat="server" />
</asp:Content>

