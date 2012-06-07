<%@ Control Language="C#" AutoEventWireup="true" CodeFile="VirtualPageList.ascx.cs"
    Inherits="EBS.HamptonDwell.Web.Admin.VirtualPageList" %>
<article class="module width_full">
			<header><h3>Virtual Page Listing</h3></header>
<div class="tab_container">
    <div id="tab1" class="tab_content" style="width: 600px;">
        <table class="tablesorter" cellspacing="0">
            <thead>
                <tr>
                    <th>
                    </th>
                    <th>
                        Page Name
                    </th>
                    <th>
                        Path
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
            <% for (int i = 0; i < Model.VirtualPageObjects.Count; i++)
               { %>
            <tbody>
                <tr>
                    <td>
                        <input type="checkbox">
                    </td>
                    <td>
                        <%= Model.VirtualPageObjects[i].PageName %>
                    </td>
                    <td>
                        <%= Model.VirtualPageObjects[i].Path %>
                    </td>
                    <td>
                        <%= Model.VirtualPageObjects[i].CreatedOn.ToShortDateString() %>
                    </td>
                               <td>
                        <%= Model.VirtualPageObjects[i].ModifiedOn.ToShortDateString() %>
                    </td>
                    <td>
                        <a href="../VirtualPageEdit.aspx?virtualPageId=<%=Model.VirtualPageObjects[i].VirtualPageId.ToString() %>">
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
