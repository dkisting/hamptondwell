<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Admin.master" %>

<%@ Register src="UserControls/UserList.ascx" tagname="UserList" tagprefix="uc1" %>

<script runat="server">

</script>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <uc1:UserList ID="UserList1" runat="server" />
</asp:Content>

