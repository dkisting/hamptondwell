<%@ Control Language="C#" AutoEventWireup="true" CodeFile="SystemConstantsList.ascx.cs"
    Inherits="EBS.HamptonDwell.Web.Admin.SystemConstantList" %>
<article class="module width_full">
			<header><h3>System Constant Listing</h3></header>
<div class="tab_container">
    <div id="tab1" class="tab_content" style="width: 800px;">
        <table class="tablesorter" cellspacing="0">
            <thead>
                <tr>
                    <th>
                    </th>
                    <th>
                        Constant Name
                    </th>
                    <th>
                        Value
                    </th>
                    <th>
                        Created On
                    </th>
                      <th>
                        Modified On
                    </th>
                    <th>
                        Actions
                    </th>
                </tr>
            </thead>
            <% for (int i = 0; i < Model.SystemConstantList.Count; i++)
               { %>
            <tbody>
                <tr>
                    <td>
                        <input type="checkbox">
                    </td>
                    <td>
                        <%= Model.SystemConstantList[i].Name%>
                    </td>
                    <td>
                        <%= Model.SystemConstantList[i].ConstantValue%>
                    </td>
                    <td>
                        <%= Model.SystemConstantList[i].CreatedOn.ToShortDateString() %>
                    </td>
                        <td>
                        <%= Model.SystemConstantList[i].ModifiedOn.ToShortDateString() %>
                    </td>
                    <td>
                        <a href="../SystemConstantEdit.aspx?systemConstantId=<%=Model.SystemConstantList[i].SystemConstantId.ToString() %>">
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
