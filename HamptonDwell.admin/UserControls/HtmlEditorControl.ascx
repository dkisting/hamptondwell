<%@ Control Language="C#" AutoEventWireup="true" CodeFile="HtmlEditorControl.ascx.cs" Inherits="EBS.HamptonDwell.Web.Admin.HTMLEditorControl" %>
<%@ Register TagPrefix="CE" Namespace="CuteEditor" Assembly="CuteEditor" %> 
<CE:Editor id="Editor1" EnableStripScriptTags="false" 
    EditorWysiwygModeCss="~/css/tabs-no-images.css" ConvertHTMLTagstoLowercase="true" 

 EnableStripStyleTagsCodeInjection="false" EnableStripIframeTags="false" UseHTMLEntities="True"  MaintainAspectRatioWhenDraggingImage="True" runat="server" StyleWithCSS="True" 
    Width="100%" Height="520px" ThemeType="Office2007" /> 

<asp:PlaceHolder runat="server" ID="EditorControl"></asp:PlaceHolder>