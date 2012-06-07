<%@ Control Language="C#" AutoEventWireup="true" CodeFile="SystemConstantEdit.ascx.cs"
    Inherits="EBS.HamptonDwell.Web.Admin.SystemConstantEdit" %>
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
        $("input[id=btnCancel]").click(function () {
            window.location.href = 'SystemConstants.aspx';
        });
    });
</script>
<input type="hidden" name="systemConstantIDInput" id="systemConstantIDInput" runat="server"/>
<span id="spanMessage" runat="server" style="display: none">
    <h4 class="alert_success" id="messageTitle" runat="server">
        <asp:Literal runat="server" ID="litMessage"></asp:Literal></h4>
</span>
<article class="module width_full">
			<header><h3>System Constant Edit</h3></header>
				<div class="module_content">
						<fieldset>
							<label>Constant Name</label>
						    <input type="text" id="txtConstantName" runat="server" Value='<%# Model.SystemConstantObject.Name %>' />
                             <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtConstantName" Display="Dynamic" ErrorMessage="Name is required" CssClass="required_field" />
						</fieldset>
                        	<fieldset>
							<label>Constant Value</label>
						    <input type="text" id="txtConstantValue" runat="server" value="<%# Model.SystemConstantObject.ConstantValue %>" />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtConstantValue" Display="Dynamic" ErrorMessage="Value is required" CssClass="required_field" />
						</fieldset>
                         <fieldset>
							<label>Active?</label>
						    <input type="checkbox" id="chkActive" runat="server" checked='<%# Model.SystemConstantObject.Active %>' />
						</fieldset><div style="clear: both"></div>
                        <% if (Model.SystemConstantObject.SystemConstantId > 0)
                           { %>
                         	<fieldset>
							<label>Created</label>
						    <%= Model.SystemConstantObject.CreatedOn.ToShortDateString() %>
						</fieldset>
                         	<fieldset>
							<label>Last Modified</label>
						    <%= Model.SystemConstantObject.ModifiedOn.ToShortDateString() %>
						</fieldset>
                        <% } %>
				</div>
                
<footer>
				<div class="submit_link">
	
                    <input type="button" id="btnSave" value="Save" class="alt_btn">
					<input type="button" value="Reset" id="btnCancel">
                            <div style="display: none">
                            <asp:Button ID="lbSubmit" CssClass="inputClick" runat="server" OnClick="Save_Click" />
                        </div>
				</div>
			</footer>
</article>
