<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Login.ascx.cs" Inherits="EBS.HamptonDwell.Web.Admin.LoginControl" %>
 <div>
        <p>
            <asp:Label ID="lblMessage" runat="server" Font-Bold="True" ForeColor="red"></asp:Label>
        </p>
        <article class="module width_full">
			<header><h3>Enter user name and password to begin</h3></header>
				<div class="module_content">
				<p>
                        User Name:</p>
                    <asp:TextBox ID="txtUserName" runat="server" Width="180px" MaxLength="50" CssClass="medium"></asp:TextBox><br>
                    <asp:RequiredFieldValidator ID="rfvUserName" runat="server" Display="Dynamic" ErrorMessage="User Name is required.<br>"
                        ControlToValidate="txtUserName"></asp:RequiredFieldValidator>
                    <p>
                        Password:</p>
                    <asp:TextBox ID="txtPassword" runat="server" Width="180px" MaxLength="20" CssClass="medium"
                        TextMode="Password"></asp:TextBox><br>
                                  <asp:RequiredFieldValidator
                            ID="rfvPassword" runat="server" Display="Dynamic" ErrorMessage="Password is required."
                            ControlToValidate="txtPassword"></asp:RequiredFieldValidator>
                            <p>
                    <asp:Button ID="btnSubmit" runat="server" OnClick="Login_Click" CssClass="alt_btn" Text="Login" />
                        
					<input type="button" value="Reset">
          </p>
				</div>
		</article>
        <!-- end of styles article -->
        <div class="spacer">
        </div>
    </div>