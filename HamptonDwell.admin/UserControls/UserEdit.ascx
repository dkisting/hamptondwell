<%@ Control Language="C#" AutoEventWireup="true" CodeFile="UserEdit.ascx.cs" Inherits="EBS.HamptonDwell.Web.Admin.UserEdit" %>
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
            window.location.href = 'UserList.aspx';
        });
    });
</script>
<input type="hidden" name="userIDInput" id="userIDInput" runat="server"/>
<span id="spanMessage" style="display: none" runat="server">
    <h4 class="alert_success" id="messageTitle" runat="server">
        <asp:Literal runat="server" ID="litMessage"></asp:Literal></h4>
</span>
<article class="module width_full">
			<header><h3>User Edit</h3></header>
				<div class="module_content">
						<fieldset>
							<label>First Name</label>
						    <input type="text" id="txtFirstName" runat="server" value="<%# Model.UserObject.FirstName %>" />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtFirstName" Display="Dynamic" ErrorMessage="First Name is required" CssClass="required_field" />
						</fieldset>
                        	<fieldset>
							<label>Last Name</label>
						    <input type="text" id="txtLastName" value="<%# Model.UserObject.LastName %>" runat="server" />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtLastName" Display="Dynamic" ErrorMessage="Last Name is required" CssClass="required_field" />
						</fieldset>
                        <fieldset>
							<label>Email</label>
						    <input type="text" id="txtEmail" value="<%# Model.UserObject.Email %>" runat="server" />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtEmail" Display="Dynamic" ErrorMessage="Email is required" CssClass="required_field" />
                            <asp:RegularExpressionValidator ID="regEmail" runat="server" 
                                ControlToValidate="txtEmail" Display="Dynamic" 
                                ErrorMessage="Email is not valid" CssClass="required_field" 
                                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" />
						</fieldset>
				 <fieldset>
							<label>Password</label>
						    <input type="password" id="txtPassword"  runat="server" />
						</fieldset>
                        <fieldset>
							<label>Confirm Password</label>
						    <input type="password" id="txtConfirmPassword" runat="server" />
                            <asp:CompareValidator ID="cmpPassword" ControlToValidate="txtPassword" ControlToCompare="txtConfirmPassword"
                            Display="Dynamic" ErrorMessage="Passwords Don't Match" runat="server" CssClass="required_field" />
						</fieldset>
                        <fieldset>
							<label>Active?</label>
						    <input type="checkbox" id="chkActive" checked="<%# Model.UserObject.Active %>" runat="server" />
						</fieldset><div style="clear: both"></div>
                        <% if (Model.UserObject.UserId > 0)
                           { %>
                         <div style="clear: both"></div>
                         	<fieldset>
							<label>Created</label>
						    <%# Model.UserObject.CreatedOn.ToShortDateString() %>
						</fieldset>
                         	<fieldset>
							<label>Last Modified</label>
						    <%# Model.UserObject.ModifiedOn.ToShortDateString() %>
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
