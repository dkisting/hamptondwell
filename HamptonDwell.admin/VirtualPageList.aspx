<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Admin.master" %>

<%@ Register src="UserControls/VirtualPageList.ascx" tagname="VirtualPageList" tagprefix="uc1" %>

<script runat="server">

</script>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <uc1:VirtualPageList ID="VirtualPageList1" runat="server" />
</asp:Content>

