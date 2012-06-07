<%@ Page Language="C#" Inherits="CuteEditor.Dialogs.FileBrowserPage" %>
<%@ Register TagPrefix="CE" Assembly="CuteEditor" Namespace="CuteEditor" %>
<script runat="server">
override protected void OnInit(EventArgs args)
{
	if(Context.Request.QueryString["Dialog"]=="Standard")
	{
		if(Context.Request.QueryString["IsFrame"]==null)
		{
			string FrameSrc="InsertDocument.Aspx?IsFrame=1&"+Request.ServerVariables["QUERY_STRING"];
			CuteEditor.CEU.WriteDialogOuterFrame(Context,"[[InsertDocument]]",FrameSrc);
			Context.Response.End();
		}
	}
	base.OnInit(args);
	
	InputFile.ValidateOption.MaxSizeKB=secset.MaxDocumentSize;
	InputFile.ValidateOption.AllowedFileExtensions=string.Join(",",(string[])secset.DocumentFilters.ToArray(typeof(string)));
}
</script>
<html xmlns="http://www.w3.org/1999/xhtml">
	<head>
		<title>[[InsertDocument]]</title>
		<meta http-equiv="Page-Enter" content="blendTrans(Duration=0.1)" />
		<meta http-equiv="Page-Exit" content="blendTrans(Duration=0.1)" />
		<link href='Load.ashx?type=themecss&file=dialog.css&theme=[[_Theme_]]' type="text/css"
			rel="stylesheet" />
		<!--[if IE]>
			<link href="Load.ashx?type=style&file=IE.css" type="text/css" rel="stylesheet" />
		<![endif]-->
		<script type="text/javascript" src="Load.ashx?type=dialogscript&verfix=1002&file=DialogHead.js"></script>
		<script type="text/javascript">
		function PostBackAction()
		{
			<%=Page.ClientScript.GetPostBackEventReference(hiddenAction,"")%>
		}
		</script>
		<style type="text/css">
		.row { HEIGHT: 22px }
		.cb { VERTICAL-ALIGN: middle }
		.itemimg { VERTICAL-ALIGN: middle }
		.editimg { VERTICAL-ALIGN: middle }
		.cell1 { VERTICAL-ALIGN: middle }
		.cell2 { VERTICAL-ALIGN: middle }
		.cell3 { PADDING-RIGHT: 4px; VERTICAL-ALIGN: middle; TEXT-ALIGN: right }
		.cb { }
		</style>
		<style type="text/css">
		#FolderList {
				/* for Firefox, Opera and others: */
				max-width: 220px; 
		}
		</style>
		<!--[if gte IE 5]>
		<style type="text/css">
		#FolderList {
				/* For Internet Explorer: */
			width: expression(Math.min(parseInt(this.offsetWidth), 220 ) + "px"); 
		}
		</style>
		<![endif]-->
		</style>
	</head>
	<body>
		<form runat="server" enctype="multipart/form-data" id="Form1">
			<div runat="server" id="ajaxdiv" style="padding:10px; width:100%">
				<!-- start hidden -->
				<input type="hidden" runat="server" id="hiddenDirectory" name="hiddenDirectory" />
				<input type="hidden" runat="server" id="hiddenFile" name="hiddenFile" /> <input type="hidden" runat="server" enableviewstate="false" id="hiddenAlert" name="hiddenAlert" />
				<input type="hidden" runat="server" enableviewstate="false" id="hiddenAction" onserverchange="hiddenAction_ServerChange"
					name="hiddenAction" /> <input type="hidden" runat="server" enableviewstate="false" id="hiddenActionData" name="hiddenActionData" />
				<!-- end hidden -->
				<table border="0" cellspacing="0" cellpadding="0" width="100%">
					<tr>
						<td style="width:20">
							<asp:image id="Image1" Runat="server" ImageUrl="../Load.ashx?type=image&file=openfolder.gif"></asp:image>
						</td>
						<td style="width:240" class="normal">
							<asp:label Runat="server" id="FolderDescription"></asp:label>
							<asp:dropdownlist Runat="server" ID="FolderList" Visible="False" />
						</td>
						<td>
							<asp:imagebutton id="CreateDir" BorderWidth="1" Runat="server" AlternateText="[[Createdirectory]]"
								ImageUrl="../Load.ashx?type=image&file=newfolder.gif" OnClick="CreateDir_Click" />
							<asp:imagebutton id="Copy" BorderWidth="1" Runat="server" AlternateText="[[Copyfiles]]" ImageUrl="../Load.ashx?type=image&file=Copy.gif"
								OnClick="Copy_Click" />
							<asp:imagebutton id="Move" BorderWidth="1" Runat="server" AlternateText="[[Movefiles]]" ImageUrl="../Load.ashx?type=image&file=move.gif"
								OnClick="Move_Click" />
							<img id="btn_zoom_in" src="../Load.ashx?type=image&file=zoom_in.gif" onclick="Zoom_In();"
								title="[[ZoomIn]]" class="dialogButton" /> <img id="btn_zoom_out" src="../Load.ashx?type=image&file=zoom_out.gif" onclick="Zoom_Out();"
								title="[[ZoomOut]]" class="dialogButton" /> <img id="btn_Actualsize" src="../Load.ashx?type=image&file=Actualsize.gif" onclick="Actualsize();"
								title="[[ActualSize]]" class="dialogButton" />
						</td>
					</tr>
				</table>
				<table border="0" cellspacing="0" cellpadding="2" width="100%">
					<tr>
						<td valign="top" style="white-space:nowrap;width:270">
							<div style="BORDER: 1.5pt inset; VERTICAL-ALIGN: middle; OVERFLOW: auto; WIDTH: 270; HEIGHT: 240px; BACKGROUND-COLOR: white">
								<asp:table id="FoldersAndFiles" Runat="server" CellSpacing="1" CellPadding="1" Width="100%"
									CssClass="sortable">
									<asp:tablerow BackColor="#f0f0f0">
										<asp:tableheadercell Width="16px">
											<asp:imagebutton id="Delete" Runat="server" AlternateText="[[Deletefiles]]" ImageUrl="../Load.ashx?type=image&file=s_cut.gif"
												OnClick="Delete_Click" />
										</asp:tableheadercell>
										<asp:tableheadercell Width="16px">
											<asp:imagebutton id="DoRefresh" Runat="server" AlternateText="[[Refresh]]" ImageUrl="../Load.ashx?type=image&file=s_refresh.gif"
												OnClick="DoRefresh_Click" />
										</asp:tableheadercell>
										<asp:tableheadercell id="name_Cell" Width="136px" CssClass="filelistHeadCol" Font-Bold="False">[[Name]]</asp:tableheadercell>
										<asp:tableheadercell id="size_Cell" Width="72px" CssClass="filelistHeadCol" Wrap="False" Font-Bold="False">[[Size]]</asp:tableheadercell>
										<asp:tableheadercell id="op_Cell" Width="16px">&nbsp;</asp:tableheadercell>
									</asp:tablerow>
								</asp:table>
							</div>
						</td>
						<td valign="top">
							<div style="padding:0; BORDER: 1.5pt inset; VERTICAL-ALIGN: top; OVERFLOW: auto; WIDTH: 300px; BORDER-BOTTOM: 1.5pt inset; HEIGHT: 240px; BACKGROUND-COLOR: white; TEXT-ALIGN: left">
								<div id="divpreview" style="BACKGROUND-COLOR: white">&nbsp;</div>
							</div>
						</td>
					</tr>
				</table>
				<table border="0" cellspacing="2" cellpadding="0" width="98%">
					<tr>
						<td valign="top">
							<fieldset>
								<legend>[[Properties]]</legend>
								<table border="0" cellpadding="4" cellspacing="0" id="Table3">
									<tr>
										<td>
											<table border="0" cellpadding="1" cellspacing="0" id="Table4" class="normal">
												<tr>
													<td>[[Target]]</td>
													<td><select id="sel_target">
															<option value="">[[NotSet]]</option>
															<option value="_blank">[[Newwindow]]</option>
															<option value="_self">[[Samewindow]]</option>
															<option value="_top">[[Topmostwindow]]</option>
															<option value="_parent">[[Parentwindow]]</option>
														</select>
													</td>
												</tr>
												<tr>
													<td>[[Color]]:</td>
													<td>
														<input type="text" id="inp_color" name="inp_color" size="7" style="WIDTH:57px" />
														<img title="" src="../Load.ashx?type=image&file=colorpicker.gif" id="inp_color_preview"
															style="vertical-align:top;" />
													</td>
												</tr>
												<tr>
													<td>[[CssClass]]:</td>
													<td><input id="inc_class" type="text" size="14" style="WIDTH:80px" name="inc_class" /></td>
												</tr>
												<tr>
													<td>[[ID]]:</td>
													<td><input id="inp_id" type="text" size="14" style="WIDTH:80px" name="inp_id" /></td>
												</tr>
												<tr>
													<td>[[TabIndex]]:</td>
													<td><input id="inp_index" type="text" size="14" maxlength="5" style="WIDTH:80px" name="inp_index"
															onkeypress="return CancelEventIfNotDigit()" /></td>
												</tr>
												<tr>
													<td>[[AccessKey]]:</td>
													<td><input id="inp_access" type="text" size="14" maxlength="1" style="WIDTH:80px" name="inp_access"
															onkeypress="return CancelEventIfNotDigit()" /></td>
												</tr>
											</table>
										</td>
									</tr>
								</table>
							</fieldset>
						</td>
						<td style="width:10">
						</td>
						<td valign="top">
							<fieldset>
								<legend>[[Insert]]</legend>
								<table border="0" cellpadding="4" cellspacing="0">
									<tr>
										<td>
											<table id="Table8" cellspacing="0" cellpadding="1" border="0" class="normal">
												<tr>
													<td valign="middle">[[Url]]:</td>
													<td>
														<input id="TargetUrl" onchange="do_preview()" onpropertychange="do_preview()" type="text"
															size="40" name="TargetUrl" runat="server" />
													</td>
												</tr>
												<tr>
													<td valign="middle">[[Title]]:</td>
													<td valign="middle"><input id="inp_title" type="text" size="40" name="inp_title" /></td>
												</tr>
											</table>
										</td>
									</tr>
								</table>
							</fieldset>
							<fieldset id="fieldsetUpload">
								<legend>
								[[Upload]] ([[MaxFileSizeAllowed]]
								<%= CuteEditor.Impl.FileStorage.FormatSize(secset.MaxDocumentSize * 1024)%>
								)</legend>
								<table border="0" cellspacing="1" cellpadding="0" width="98%" class="normal">
									<tr>
										<td style="height:12">
										</td>
									</tr>
									<tr>
										<td valign="top" id="uploader">
											<ce:uploader id="InputFile" runat="server"></ce:uploader>
										</td>
									</tr>
									<tr>
										<td style="width:8">
										</td>
									</tr>
									<tr>
										<td style="width:5">
										</td>
									</tr>
									<tr>
										<td>
											<span style="white-space:nowrap">[[MaxFolderSizeAllowed]]:
											<%= CuteEditor.Impl.FileStorage.FormatSize(secset.MaxDocumentFolderSize * 1024)%>.
											[[Used]]:<%= CuteEditor.Impl.FileStorage.FormatSize(fs.GetDirectorySize(fs.VirtualRoot)) %>
											<span style="background-color:green;height:3px;width:40px;font-size:3px">
													<span style="background-color:red;height:3px;width:<%= GetUsedSpaceBarWidth() %>px;font-size:3px">
													</span>
												</span>
										</span>
										</td>
									</tr>
								</table>
							</fieldset>
							<br>
							<div style="padding-top:4px;">
								<input class="formbutton" type="button" value="   [[Insert]]   " onclick="do_insert()"
									id="Button1" /> &nbsp;&nbsp;&nbsp; <input class="formbutton" type="button" value="   [[Cancel]]   " onclick="do_Close()" id="Button2" />
							</div>
						</td>
					</tr>
				</table>
			</div>
		</form>
		<script runat="server">
	protected override void InitOfType()
	{
		string folder=secset.FilesGalleryPath;

		string[] flist=folder.Split('|');
		if(flist.Length<2)
		{
			fs.VirtualRoot=CuteEditor.EditorUtility.ProcessWebPath(Context,null,folder).TrimEnd('/')+"/";
			return;
		}
		
		_multiplefolderlist=flist;
		
		//just set display to none, maybe javascript need it.
		FolderDescription.Style["display"]="none";
		
		for(int i=0;i<flist.Length;i++)
		{
			flist[i]=CuteEditor.EditorUtility.ProcessWebPath(Context,null,flist[i]).TrimEnd('/')+"/";
		}
		
		FolderList.DataSource=flist;
		FolderList.DataBind();
		FolderList.Visible=true;
		FolderList.AutoPostBack=true;
		FolderList.SelectedIndexChanged+=new EventHandler(FolderList_SelectedIndexChanged);
		Page.Load+=new EventHandler(Page_Load_ForFolderList);
		
		fs.VirtualRoot=flist[0];
	}
	
	string[] _multiplefolderlist;
	void Page_Load_ForFolderList(object sender,EventArgs args)
	{
		fs.VirtualRoot=_multiplefolderlist[FolderList.SelectedIndex];
	}
	void FolderList_SelectedIndexChanged(object sender,EventArgs args)
	{
		for(int i=0;i<FolderList.Items.Count;i++)
		{
			FolderList.Items[i].Text=FolderList.Items[i].Value;
		}
		fs.VirtualRoot=_multiplefolderlist[FolderList.SelectedIndex];
		CurrentDirectory=fs.VirtualRoot;
		Refresh();
	}
	protected override void OnPreRender(EventArgs args)
	{
		base.OnPreRender(args);
		if(FolderList.Visible)
		{
			FolderList.SelectedItem.Text=FolderDescription.Text;
		}
	}
	protected override bool HideDirectoryItem(CuteEditor.Impl.DirectoryItem item)
	{
		//write custom code to filter the directories
		return base.HideDirectoryItem(item);
	}
	protected override bool HideFileItem(CuteEditor.Impl.FileItem item)
	{
		//write custom code to filter the files
		return base.HideFileItem(item);
	}
	
	
    protected override void GetFiles(ArrayList files)
    {
        foreach (string ext in secset.DocumentFilters)
        {
            if (ext == null || ext.Length == 0) continue;
            
			files.AddRange(fs.GetFileItems(CurrentDirectory, secset.FileNamePrefix + "*" + ext));
        }        
        
    }
    protected override bool AllowFileName(string filename)
    {
        filename = filename.ToLower();
        foreach (string ext in secset.DocumentFilters)
        {
            if (ext == null || ext.Length == 0) continue;
            if(filename.EndsWith(ext.ToLower()))
                return true;
        }
        return false;
    }
    protected override string CheckUploadData(ref byte[] data)
    {
		if (fs.GetDirectorySize(fs.VirtualRoot) >= secset.MaxDocumentFolderSize * 1024)
           return "File folder size exceeds the limit: "+ CuteEditor.Impl.FileStorage.FormatSize(secset.MaxDocumentFolderSize * 1024);

		if (data.Length >= secset.MaxDocumentSize * 1024)
            return "File size exceeds "+CuteEditor.Impl.FileStorage.FormatSize(secset.MaxDocumentSize * 1024)+" limit: "+ CuteEditor.Impl.FileStorage.FormatSize(data.Length);
        return null;
    }
    
    protected int GetUsedSpaceBarWidth()
    {
      int w = Convert.ToInt32(40*fs.GetDirectorySize(fs.VirtualRoot)/(secset.MaxDocumentFolderSize * 1024));
      if(w<1)
		w=1;
		
	  if(w>40)
		w=40;
		
      return w;      
    }
		</script>
	</body>
	<script type="text/javascript" src="Load.ashx?type=dialogscript&verfix=1002&file=DialogFoot.js"></script>
	<script type="text/javascript" src="Load.ashx?type=dialogscript&verfix=1002&file=Dialog_InsertDocument.js"></script>
</html>
