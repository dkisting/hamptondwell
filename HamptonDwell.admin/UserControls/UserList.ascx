<%@ Control Language="C#" AutoEventWireup="true" CodeFile="UserList.ascx.cs" Inherits="EBS.HamptonDwell.Web.Admin.UserList" %>
<article class="module width_full">
			<header><h3>System User Listing</h3></header>
<div class="tab_container">
    <div id="tab1" class="tab_content" style="width: 600px;">
        <table class="tablesorter" cellspacing="0">
            <thead>
                <tr>
                    <th>
                    </th>
                    <th>
                        Last Name
                    </th>
                    <th>
                        First Name
                    </th>
                    <th>
                        Email
                    </th>
                    <th>
                        Actions
                    </th>
                </tr>
            </thead>
            <% for (int i = 0; i < Model.UserObjects.Count; i++)
               { %>
            <tbody>
                <tr>
                    <td>
                        <input type="checkbox">
                    </td>
                    <td>
                        <%= Model.UserObjects[i].LastName %>
                    </td>
                    <td>
                        <%= Model.UserObjects[i].FirstName%>
                    </td>
                    <td>
                        <%= Model.UserObjects[i].Email%>
                    </td>
                    <td>
                        <a href="../UserEdit.aspx?userId=<%=Model.UserObjects[i].UserId.ToString() %>">
                        <img border="0" src="images/icn_edit.png" title="Edit"></a>&nbsp;<a href="#"><img border="0" src="images/icn_trash.png"
                            title="Trash"></a>
                    </td>
                </tr>
                <% } %>
            </tbody>
        </table>
    </div>
</div>
            </article>
