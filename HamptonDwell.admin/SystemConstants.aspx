<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Admin.master" %>

<%@ Register src="UserControls/SystemConstantsList.ascx" tagname="SystemConstantsList" tagprefix="uc1" %>

<script runat="server">

</script>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <uc1:SystemConstantsList ID="SystemConstantsList1" runat="server" />
</asp:Content>

