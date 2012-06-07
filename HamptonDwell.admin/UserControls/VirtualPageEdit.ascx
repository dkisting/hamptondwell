<%@ Control Language="C#" AutoEventWireup="true" CodeFile="VirtualPageEdit.ascx.cs"
    Inherits="EBS.HamptonDwell.Web.Admin.VirtualPageEdit" %>
<%@ Import Namespace="EBS.HamptonDwell.Web.Logic.Services.VirtualPages" %>
<%@ Register Src="htmleditorcontrol.ascx" TagName="htmleditorcontrol" TagPrefix="uc1" %>
<script language="javascript" type="text/javascript">
    function ValidatePage() {

        if (typeof (Page_ClientValidate) == 'function') {
            Page_ClientValidate();
        }

        if (Page_IsValid) {
            return true;
        }
        else {
            return false;
        }

    }

    $(function () {

        $("input[id=btnSave]").click(function () {

            if (ValidatePage()) {
                this.disabled = true;

                $(".inputClick")[0].click();
            }
        });
        $("input[id=btnPublish]").click(function () {

            if (ValidatePage()) {
                this.disabled = true;

                $(".publishClick")[0].click();
            }
        });
        $("input[id=btnCancel]").click(function () {
            window.location.href = 'VirtualPageList.aspx';
        });
    });
</script>
<input type="hidden" name="virtualPageInput" id="virtualPageInput" runat="server" />
<span id="spanMessage" runat="server" style="display: none">
    <h4 class="alert_success" id="messageTitle" runat="server">
        <asp:Literal runat="server" ID="litMessage"></asp:Literal></h4>
</span>
<article class="module width_full">
			<header><h3>Virtual Page Edit</h3></header>
				<div class="module_content">
						<fieldset style="width:40%; float:left; margin-right: 3%;">
							<label>Unique Name</label>
						    <input type="text" id="txtPageName" runat="server" style="width: 90%" value="<%# Model.VirtualPagesObject.PageName %>" />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtPageName" Display="Dynamic" ErrorMessage="Unique Name is required" CssClass="required_field" />
						</fieldset>
                        	<fieldset style="width:40%; float:left; margin-right: 3%; white-space: nowrap">
							<label>Path</label>
						    <input type="text" id="txtPath" value="<%# Model.VirtualPagesObject.Path %>" style="width: 90%" runat="server" />
                        	    <asp:RequiredFieldValidator runat="server" ControlToValidate="txtPath" Display="Dynamic" ErrorMessage="Path is required" CssClass="required_field" />
						</fieldset>
                        <div class="clear"></div>
                                   	<fieldset>
							<label>Page Title</label>
						    <input type="text" id="txtPageTitle" value="<%# Model.VirtualPagesObject.PageTitle %>" runat="server" />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPageTitle" Display="Dynamic" ErrorMessage="Page Title is required" CssClass="required_field" />
						</fieldset>
                             	<fieldset>
							<label>Meta Description</label>
						    <input type="text" id="txtMetaDescription" value="<%# Model.VirtualPagesObject.MetaDescription %>" runat="server" />
						</fieldset>
                        <fieldset> <!-- to make two field float next to one another, adjust values accordingly -->
							<label>Tags (separated by ";")</label>
							<input type="text" id="txtKeywords" value="<%# Model.VirtualPagesObject.Keywords %>" runat="server"/>
						</fieldset>
				    <fieldset>
							<label>Is a Template?</label>
						    <input type="checkbox" id="chkTemplate" runat="server" checked="<%# Model.VirtualPagesObject.IsTemplate %>" />
						</fieldset>
                         <fieldset>
							<label>Active?</label>
						    <input type="checkbox" id="chkActive" checked="<%# Model.VirtualPagesObject.Active %>" runat="server" />
						</fieldset><div class="clear"></div>
                        
						<fieldset>
							<label>Content</label>&nbsp;
                            <uc1:htmleditorcontrol ID="PageContent" runat="server" Text="<%# Model.VirtualPagesObject.PageContent %>" />

						</fieldset>
						<fieldset style="width:30%; float:left; margin-right: 1%;"> <!-- to make two field float next to one another, adjust values accordingly -->
							<label>Template</label>
						    <asp:DropDownList runat="server" ID="ddlPageTemplate" Width="92%" />
                            
						</fieldset>
                        		<fieldset style="width:30%; float:left; margin-right: 1%;"> <!-- to make two field float next to one another, adjust values accordingly -->
							<label>Page Page</label>
                        		    <asp:DropDownList runat="server"  ID="ddlMemberOf"  Width="92%" />
						</fieldset>
						<div class="clear"></div>
				</div>
			<footer>
				<div class="submit_link">
				<input type="button" id="btnPublish" value="Publish" class="alt_btn">
                   <input type="button" id="btnSave" value="Save" class="alt_btn">
					<input type="button" value="Reset" id="btnCancel">
                            <div style="display: none">
                                <asp:Button ID="lbPublish" CssClass="publishClick" CausesValidation="True" runat="server" OnClick="SaveAndPublish_Click" />
                            <asp:Button ID="lbSubmit" CssClass="inputClick" CausesValidation="True" runat="server" OnClick="Save_Click" />
                        </div>
				</div>
			</footer>
		</article>
