var OxO9a35=["top","hiddenDirectory","hiddenFile","hiddenAlert","hiddenAction","hiddenActionData","This function is disabled in the demo mode.","disabled","[[Disabled]]","[[SpecifyNewFolderName]]","","value","createdir","[[CopyMoveto]]","/","move","copy","[[AreyouSureDelete]]","parentNode","text","isdir","true",".","[[SpecifyNewFileName]]","rename","True","False",":","path","FoldersAndFiles","TR","length","onmouseover","this.bgColor=\x27#eeeeee\x27;","onmouseout","this.bgColor=\x27\x27;","nodeName","INPUT","changedir","url","TargetUrl","htmlcode","onload","getElementsByTagName","table","sortable"," ","className","id","rows","cells","innerHTML","\x3Ca href=\x22#\x22 onclick=\x22ts_resortTable(this);return false;\x22\x3E","\x3Cspan class=\x22sortarrow\x22\x3E\x26nbsp;\x3C/span\x3E\x3C/a\x3E","string","undefined","innerText","childNodes","nodeValue","nodeType","span","cellIndex","TABLE","sortdir","down","\x26uarr;","up","\x26darr;","sortbottom","tBodies","sortarrow","\x26nbsp;","20","19","Form1","Image1","FolderDescription","CreateDir","Copy","Move","Delete","DoRefresh","name_Cell","size_Cell","op_Cell","divpreview","Table3","Table4","sel_target","inp_color","inp_color_preview","inc_class","inp_id","inp_index","inp_access","Table8","inp_title","Button1","Button2","btn_zoom_in","btn_zoom_out","btn_Actualsize","a","editor","color","style","backgroundColor","class","title","target","tabIndex","accessKey","href","href_cetemp",".jpeg",".jpg",".gif",".png","\x3CIMG src=\x27","\x27\x3E",".bmp","\x26nbsp;\x3Cembed src=\x22","\x22 quality=\x22high\x22 width=\x22200\x22 height=\x22200\x22 type=\x22application/x-shockwave-flash\x22 pluginspage=\x22http://www.macromedia.com/go/getflashplayer\x22\x3E\x3C/embed\x3E\x0A",".swf",".avi",".mpg",".mp3","\x26nbsp;\x3Cembed name=\x22MediaPlayer1\x22 src=\x22","\x22 autostart=-1 showcontrols=-1  type=\x22application/x-mplayer2\x22 width=\x22240\x22 height=\x22200\x22 pluginspage=\x22http://www.microsoft.com/Windows/MediaPlayer\x22 \x3E\x3C/embed\x3E\x0A",".mpeg","\x3Cdiv\x3E\x3C/div\x3E","\x3Cdiv\x3E\x26nbsp;\x3C/div\x3E","\x3Cdiv\x3E\x26#160;\x3C/div\x3E","\x3Cp\x3E\x3C/p\x3E","\x3Cp\x3E\x26#160;\x3C/p\x3E","\x3Cp\x3E\x26nbsp;\x3C/p\x3E","name","zoom","onclick","display","none","align","absmiddle","wrapupPrompt","iepromptfield","body","div","IEPromptBox","promptBlackout","border","1px solid #b0bec7","#f0f0f0","position","absolute","width","330px","zIndex","100","\x3Cdiv style=\x22width: 100%; padding-top:3px;background-color: #DCE7EB; font-family: verdana; font-size: 10pt; font-weight: bold; height: 22px; text-align:center; background:url(Load.ashx?type=image\x26file=formbg2.gif) repeat-x left top;\x22\x3E[[InputRequired]]\x3C/div\x3E","\x3Cdiv style=\x22padding: 10px\x22\x3E","\x3CBR\x3E\x3CBR\x3E","\x3Cform action=\x22\x22 onsubmit=\x22return wrapupPrompt()\x22\x3E","\x3Cinput id=\x22iepromptfield\x22 name=\x22iepromptdata\x22 type=text size=46 value=\x22","\x22\x3E","\x3Cbr\x3E\x3Cbr\x3E\x3Ccenter\x3E","\x3Cinput type=\x22submit\x22 value=\x22\x26nbsp;\x26nbsp;\x26nbsp;[[OK]]\x26nbsp;\x26nbsp;\x26nbsp;\x22\x3E","\x26nbsp;\x26nbsp;\x26nbsp;\x26nbsp;\x26nbsp;\x26nbsp;","\x3Cinput type=\x22button\x22 onclick=\x22wrapupPrompt(true)\x22 value=\x22\x26nbsp;[[Cancel]]\x26nbsp;\x22\x3E","\x3C/form\x3E\x3C/div\x3E","100px","left","offsetWidth","px","block","CuteEditor_ColorPicker_ButtonOver(this)"];function Window_GetDialogTop(Ox1a1){return Ox1a1[OxO9a35[0]];} ;var hiddenDirectory=Window_GetElement(window,OxO9a35[1],true);var hiddenFile=Window_GetElement(window,OxO9a35[2],true);var hiddenAlert=Window_GetElement(window,OxO9a35[3],true);var hiddenAction=Window_GetElement(window,OxO9a35[4],true);var hiddenActionData=Window_GetElement(window,OxO9a35[5],true);function CreateDir_click(){if(isDemoMode){alert(OxO9a35[6]);return false;} ;if(Event_GetSrcElement()[OxO9a35[7]]){alert(OxO9a35[8]);return false;} ;if(Browser_IsIE7()){IEprompt(Ox218,OxO9a35[9],OxO9a35[10]);function Ox218(Ox379){if(Ox379){hiddenActionData[OxO9a35[11]]=Ox379;hiddenAction[OxO9a35[11]]=OxO9a35[12];window.PostBackAction();return true;} else {return false;} ;} ;return Event_CancelEvent();} else {var Ox379=prompt(OxO9a35[9],OxO9a35[10]);if(Ox379){hiddenActionData[OxO9a35[11]]=Ox379;return true;} else {return false;} ;return false;} ;} ;function Move_click(){if(isDemoMode){alert(OxO9a35[6]);return false;} ;if(Event_GetSrcElement()[OxO9a35[7]]){alert(OxO9a35[8]);return false;} ;if(Browser_IsIE7()){IEprompt(Ox218,OxO9a35[13],OxO9a35[14]);function Ox218(Ox379){if(Ox379){hiddenActionData[OxO9a35[11]]=Ox379;hiddenAction[OxO9a35[11]]=OxO9a35[15];window.PostBackAction();return true;} else {return false;} ;} ;return Event_CancelEvent();} else {var Ox379=prompt(OxO9a35[13],OxO9a35[14]);if(Ox379){hiddenActionData[OxO9a35[11]]=Ox379;return true;} else {return false;} ;return false;} ;} ;function Copy_click(){if(isDemoMode){alert(OxO9a35[6]);return false;} ;if(Event_GetSrcElement()[OxO9a35[7]]){alert(OxO9a35[8]);return false;} ;if(Browser_IsIE7()){IEprompt(Ox218,OxO9a35[13],OxO9a35[14]);function Ox218(Ox379){if(Ox379){hiddenActionData[OxO9a35[11]]=Ox379;hiddenAction[OxO9a35[11]]=OxO9a35[16];window.PostBackAction();return true;} else {return false;} ;} ;return Event_CancelEvent();} else {var Ox379=prompt(OxO9a35[13],OxO9a35[14]);if(Ox379){hiddenActionData[OxO9a35[11]]=Ox379;return true;} else {return false;} ;return false;} ;} ;function Delete_click(){if(isDemoMode){alert(OxO9a35[6]);return false;} ;if(Event_GetSrcElement()[OxO9a35[7]]){alert(OxO9a35[8]);return false;} ;return confirm(OxO9a35[17]);} ;function EditImg_click(img){if(isDemoMode){alert(OxO9a35[6]);return false;} ;if(img[OxO9a35[7]]){alert(OxO9a35[8]);return false;} ;var Ox37e=img[OxO9a35[18]][OxO9a35[18]];var Ox37f=Ox37e[OxO9a35[19]];var name;var Ox380;if(Browser_IsOpera()){Ox380=Ox37e.getAttribute(OxO9a35[20])==OxO9a35[21];} else {Ox380=Ox37e[OxO9a35[20]];} ;if(Browser_IsIE7()){var Oxc3;if(Ox380){IEprompt(Ox218,OxO9a35[9],Ox37f);} else {var i=Ox37f.lastIndexOf(OxO9a35[22]);Oxc3=Ox37f.substr(i);var Ox12=Ox37f.substr(0,Ox37f.lastIndexOf(OxO9a35[22]));IEprompt(Ox218,OxO9a35[23],Ox12);} ;function Ox218(Ox379){if(Ox379&&Ox379!=Ox37e[OxO9a35[19]]){if(!Ox380){Ox379=Ox379+Oxc3;} ;hiddenAction[OxO9a35[11]]=OxO9a35[24];hiddenActionData[OxO9a35[11]]=(Ox380?OxO9a35[25]:OxO9a35[26])+OxO9a35[27]+Ox37e[OxO9a35[28]]+OxO9a35[27]+Ox379;window.PostBackAction();} ;} ;} else {if(Ox380){name=prompt(OxO9a35[9],Ox37f);} else {var i=Ox37f.lastIndexOf(OxO9a35[22]);var Oxc3=Ox37f.substr(i);var Ox12=Ox37f.substr(0,Ox37f.lastIndexOf(OxO9a35[22]));name=prompt(OxO9a35[23],Ox12);if(name){name=name+Oxc3;} ;} ;if(name&&name!=Ox37e[OxO9a35[19]]){hiddenAction[OxO9a35[11]]=OxO9a35[24];hiddenActionData[OxO9a35[11]]=(Ox380?OxO9a35[25]:OxO9a35[26])+OxO9a35[27]+Ox37e[OxO9a35[28]]+OxO9a35[27]+name;window.PostBackAction();} ;} ;return Event_CancelEvent();} ;setMouseOver();function setMouseOver(){var FoldersAndFiles=Window_GetElement(window,OxO9a35[29],true);var Ox383=FoldersAndFiles.getElementsByTagName(OxO9a35[30]);for(var i=0;i<Ox383[OxO9a35[31]];i++){var Ox37e=Ox383[i];Ox37e[OxO9a35[32]]= new Function(OxO9a35[10],OxO9a35[33]);Ox37e[OxO9a35[34]]= new Function(OxO9a35[10],OxO9a35[35]);} ;} ;function row_click(Ox37e){var Ox380;if(Browser_IsOpera()){Ox380=Ox37e.getAttribute(OxO9a35[20])==OxO9a35[21];} else {Ox380=Ox37e[OxO9a35[20]];} ;if(Ox380){if(Event_GetSrcElement()[OxO9a35[36]]==OxO9a35[37]){return ;} ;hiddenAction[OxO9a35[11]]=OxO9a35[38];hiddenActionData[OxO9a35[11]]=Ox37e.getAttribute(OxO9a35[28]);window.PostBackAction();} else {var Ox102=Ox37e.getAttribute(OxO9a35[28]);hiddenFile[OxO9a35[11]]=Ox102;var Ox280=Ox37e.getAttribute(OxO9a35[39]);Window_GetElement(window,OxO9a35[40],true)[OxO9a35[11]]=Ox280;var htmlcode=Ox37e.getAttribute(OxO9a35[41]);if(htmlcode!=OxO9a35[10]&&htmlcode!=null){do_preview(htmlcode);} else {try{Actualsize();} catch(x){do_preview();} ;} ;} ;} ;function do_preview(){} ;function reset_hiddens(){if(hiddenAlert[OxO9a35[11]]){alert(hiddenAlert.value);} ;if(TargetUrl[OxO9a35[11]]!=OxO9a35[10]&&TargetUrl[OxO9a35[11]]!=null){do_preview();} ;hiddenAlert[OxO9a35[11]]=OxO9a35[10];hiddenAction[OxO9a35[11]]=OxO9a35[10];hiddenActionData[OxO9a35[11]]=OxO9a35[10];} ;Event_Attach(window,OxO9a35[42],reset_hiddens);function RequireFileBrowseScript(){} ;Event_Attach(window,OxO9a35[42],sortables_init);var SORT_COLUMN_INDEX;function sortables_init(){if(!document[OxO9a35[43]]){return ;} ;var Ox388=document.getElementsByTagName(OxO9a35[44]);for(var Ox389=0;Ox389<Ox388[OxO9a35[31]];Ox389++){var Ox38a=Ox388[Ox389];if(((OxO9a35[46]+Ox38a[OxO9a35[47]]+OxO9a35[46]).indexOf(OxO9a35[45])!=-1)&&(Ox38a[OxO9a35[48]])){ts_makeSortable(Ox38a);} ;} ;} ;function ts_makeSortable(Ox38c){if(Ox38c[OxO9a35[49]]&&Ox38c[OxO9a35[49]][OxO9a35[31]]>0){var Ox38d=Ox38c[OxO9a35[49]][0];} ;if(!Ox38d){return ;} ;for(var i=2;i<4;i++){var Ox38e=Ox38d[OxO9a35[50]][i];var Ox27b=ts_getInnerText(Ox38e);Ox38e[OxO9a35[51]]=OxO9a35[52]+Ox27b+OxO9a35[53];} ;} ;function ts_getInnerText(Ox27){if( typeof Ox27==OxO9a35[54]){return Ox27;} ;if( typeof Ox27==OxO9a35[55]){return Ox27;} ;if(Ox27[OxO9a35[56]]){return Ox27[OxO9a35[56]];} ;var Ox24=OxO9a35[10];var Ox33a=Ox27[OxO9a35[57]];var Ox11=Ox33a[OxO9a35[31]];for(var i=0;i<Ox11;i++){switch(Ox33a[i][OxO9a35[59]]){case 1:Ox24+=ts_getInnerText(Ox33a[i]);break ;;case 3:Ox24+=Ox33a[i][OxO9a35[58]];break ;;} ;} ;return Ox24;} ;function ts_resortTable(Ox391){var Ox29e;for(var Ox392=0;Ox392<Ox391[OxO9a35[57]][OxO9a35[31]];Ox392++){if(Ox391[OxO9a35[57]][Ox392][OxO9a35[36]]&&Ox391[OxO9a35[57]][Ox392][OxO9a35[36]].toLowerCase()==OxO9a35[60]){Ox29e=Ox391[OxO9a35[57]][Ox392];} ;} ;var Ox393=ts_getInnerText(Ox29e);var Ox1dd=Ox391[OxO9a35[18]];var Ox394=Ox1dd[OxO9a35[61]];var Ox38c=getParent(Ox1dd,OxO9a35[62]);if(Ox38c[OxO9a35[49]][OxO9a35[31]]<=1){return ;} ;var Ox395=ts_getInnerText(Ox38c[OxO9a35[49]][1][OxO9a35[50]][Ox394]);var Ox396=ts_sort_caseinsensitive;if(Ox395.match(/^\d\d[\/-]\d\d[\/-]\d\d\d\d$/)){Ox396=ts_sort_date;} ;if(Ox395.match(/^\d\d[\/-]\d\d[\/-]\d\d$/)){Ox396=ts_sort_date;} ;if(Ox395.match(/^[?]/)){Ox396=ts_sort_currency;} ;if(Ox395.match(/^[\d\.]+$/)){Ox396=ts_sort_numeric;} ;SORT_COLUMN_INDEX=Ox394;var Ox38d= new Array();var Ox397= new Array();for(var i=0;i<Ox38c[OxO9a35[49]][0][OxO9a35[31]];i++){Ox38d[i]=Ox38c[OxO9a35[49]][0][i];} ;for(var j=1;j<Ox38c[OxO9a35[49]][OxO9a35[31]];j++){Ox397[j-1]=Ox38c[OxO9a35[49]][j];} ;Ox397.sort(Ox396);if(Ox29e.getAttribute(OxO9a35[63])==OxO9a35[64]){var Ox398=OxO9a35[65];Ox397.reverse();Ox29e.setAttribute(OxO9a35[63],OxO9a35[66]);} else {Ox398=OxO9a35[67];Ox29e.setAttribute(OxO9a35[63],OxO9a35[64]);} ;for(i=0;i<Ox397[OxO9a35[31]];i++){if(!Ox397[i][OxO9a35[47]]||(Ox397[i][OxO9a35[47]]&&(Ox397[i][OxO9a35[47]].indexOf(OxO9a35[68])==-1))){Ox38c[OxO9a35[69]][0].appendChild(Ox397[i]);} ;} ;for(i=0;i<Ox397[OxO9a35[31]];i++){if(Ox397[i][OxO9a35[47]]&&(Ox397[i][OxO9a35[47]].indexOf(OxO9a35[68])!=-1)){Ox38c[OxO9a35[69]][0].appendChild(Ox397[i]);} ;} ;var Ox399=document.getElementsByTagName(OxO9a35[60]);for(var Ox392=0;Ox392<Ox399[OxO9a35[31]];Ox392++){if(Ox399[Ox392][OxO9a35[47]]==OxO9a35[70]){if(getParent(Ox399[Ox392],OxO9a35[44])==getParent(Ox391,OxO9a35[44])){Ox399[Ox392][OxO9a35[51]]=OxO9a35[71];} ;} ;} ;Ox29e[OxO9a35[51]]=Ox398;} ;function getParent(Ox27,Ox39b){if(Ox27==null){return null;} else {if(Ox27[OxO9a35[59]]==1&&Ox27[OxO9a35[36]].toLowerCase()==Ox39b.toLowerCase()){return Ox27;} else {return getParent(Ox27.parentNode,Ox39b);} ;} ;} ;function ts_sort_date(Oxe7,b){var Ox39d=ts_getInnerText(Oxe7[OxO9a35[50]][SORT_COLUMN_INDEX]);var Ox39e=ts_getInnerText(b[OxO9a35[50]][SORT_COLUMN_INDEX]);if(Ox39d[OxO9a35[31]]==10){var Ox39f=Ox39d.substr(6,4)+Ox39d.substr(3,2)+Ox39d.substr(0,2);} else {var Ox3a0=Ox39d.substr(6,2);if(parseInt(Ox3a0)<50){Ox3a0=OxO9a35[72]+Ox3a0;} else {Ox3a0=OxO9a35[73]+Ox3a0;} ;var Ox39f=Ox3a0+Ox39d.substr(3,2)+Ox39d.substr(0,2);} ;if(Ox39e[OxO9a35[31]]==10){var Ox3a1=Ox39e.substr(6,4)+Ox39e.substr(3,2)+Ox39e.substr(0,2);} else {Ox3a0=Ox39e.substr(6,2);if(parseInt(Ox3a0)<50){Ox3a0=OxO9a35[72]+Ox3a0;} else {Ox3a0=OxO9a35[73]+Ox3a0;} ;var Ox3a1=Ox3a0+Ox39e.substr(3,2)+Ox39e.substr(0,2);} ;if(Ox39f==Ox3a1){return 0;} ;if(Ox39f<Ox3a1){return -1;} ;return 1;} ;function ts_sort_currency(Oxe7,b){var Ox39d=ts_getInnerText(Oxe7[OxO9a35[50]][SORT_COLUMN_INDEX]).replace(/[^0-9.]/g,OxO9a35[10]);var Ox39e=ts_getInnerText(b[OxO9a35[50]][SORT_COLUMN_INDEX]).replace(/[^0-9.]/g,OxO9a35[10]);return parseFloat(Ox39d)-parseFloat(Ox39e);} ;function ts_sort_numeric(Oxe7,b){var Ox39d=parseFloat(ts_getInnerText(Oxe7[OxO9a35[50]][SORT_COLUMN_INDEX]));if(isNaN(Ox39d)){Ox39d=0;} ;var Ox39e=parseFloat(ts_getInnerText(b[OxO9a35[50]][SORT_COLUMN_INDEX]));if(isNaN(Ox39e)){Ox39e=0;} ;return Ox39d-Ox39e;} ;function ts_sort_caseinsensitive(Oxe7,b){var Ox39d=ts_getInnerText(Oxe7[OxO9a35[50]][SORT_COLUMN_INDEX]).toLowerCase();var Ox39e=ts_getInnerText(b[OxO9a35[50]][SORT_COLUMN_INDEX]).toLowerCase();if(Ox39d==Ox39e){return 0;} ;if(Ox39d<Ox39e){return -1;} ;return 1;} ;function ts_sort_default(Oxe7,b){var Ox39d=ts_getInnerText(Oxe7[OxO9a35[50]][SORT_COLUMN_INDEX]);var Ox39e=ts_getInnerText(b[OxO9a35[50]][SORT_COLUMN_INDEX]);if(Ox39d==Ox39e){return 0;} ;if(Ox39d<Ox39e){return -1;} ;return 1;} [sortables_init];RequireFileBrowseScript();var Form1=Window_GetElement(window,OxO9a35[74],true);var hiddenDirectory=Window_GetElement(window,OxO9a35[1],true);var hiddenFile=Window_GetElement(window,OxO9a35[2],true);var hiddenAlert=Window_GetElement(window,OxO9a35[3],true);var hiddenAction=Window_GetElement(window,OxO9a35[4],true);var hiddenActionData=Window_GetElement(window,OxO9a35[5],true);var Image1=Window_GetElement(window,OxO9a35[75],true);var FolderDescription=Window_GetElement(window,OxO9a35[76],true);var CreateDir=Window_GetElement(window,OxO9a35[77],true);var Copy=Window_GetElement(window,OxO9a35[78],true);var Move=Window_GetElement(window,OxO9a35[79],true);var FoldersAndFiles=Window_GetElement(window,OxO9a35[29],true);var Delete=Window_GetElement(window,OxO9a35[80],true);var DoRefresh=Window_GetElement(window,OxO9a35[81],true);var name_Cell=Window_GetElement(window,OxO9a35[82],true);var size_Cell=Window_GetElement(window,OxO9a35[83],true);var op_Cell=Window_GetElement(window,OxO9a35[84],true);var divpreview=Window_GetElement(window,OxO9a35[85],true);var Table3=Window_GetElement(window,OxO9a35[86],true);var Table4=Window_GetElement(window,OxO9a35[87],true);var sel_target=Window_GetElement(window,OxO9a35[88],true);var inp_color=Window_GetElement(window,OxO9a35[89],true);var inp_color_preview=Window_GetElement(window,OxO9a35[90],true);var inc_class=Window_GetElement(window,OxO9a35[91],true);var inp_id=Window_GetElement(window,OxO9a35[92],true);var inp_index=Window_GetElement(window,OxO9a35[93],true);var inp_access=Window_GetElement(window,OxO9a35[94],true);var Table8=Window_GetElement(window,OxO9a35[95],true);var TargetUrl=Window_GetElement(window,OxO9a35[40],true);var inp_title=Window_GetElement(window,OxO9a35[96],true);var Button1=Window_GetElement(window,OxO9a35[97],true);var Button2=Window_GetElement(window,OxO9a35[98],true);var btn_zoom_in=Window_GetElement(window,OxO9a35[99],true);var btn_zoom_out=Window_GetElement(window,OxO9a35[100],true);var btn_Actualsize=Window_GetElement(window,OxO9a35[101],true);var obj=Window_GetDialogArguments(window);var element=null;if(obj){element=obj[OxO9a35[102]];} ;var editor=obj[OxO9a35[103]];var htmlcode=OxO9a35[10];if(element[OxO9a35[105]][OxO9a35[104]]){inp_color[OxO9a35[11]]=revertColor(element[OxO9a35[105]].color);inp_color[OxO9a35[105]][OxO9a35[106]]=inp_color[OxO9a35[11]];inp_color_preview[OxO9a35[105]][OxO9a35[106]]=inp_color[OxO9a35[11]];} ;if(element[OxO9a35[47]]==OxO9a35[10]){element.removeAttribute(OxO9a35[47]);} ;if(element[OxO9a35[47]]==OxO9a35[10]){element.removeAttribute(OxO9a35[107]);} ;if(element[OxO9a35[108]]){inp_title[OxO9a35[11]]=element[OxO9a35[108]];} ;if(element[OxO9a35[109]]){sel_target[OxO9a35[11]]=element[OxO9a35[109]];} ;if(element[OxO9a35[110]]){inp_index[OxO9a35[11]]=element[OxO9a35[110]];} ;if(element[OxO9a35[111]]){inp_access[OxO9a35[11]]=element[OxO9a35[111]];} ;var src=OxO9a35[10];if(element.getAttribute(OxO9a35[112])){src=element.getAttribute(OxO9a35[112]);} ;if(element.getAttribute(OxO9a35[113])){src=element.getAttribute(OxO9a35[113]);} ;if(TargetUrl[OxO9a35[11]]){Actualsize();} else {if(element&&src){TargetUrl[OxO9a35[11]]=src;} ;} ;inp_id[OxO9a35[11]]=element[OxO9a35[48]];var divpreview=Window_GetElement(window,OxO9a35[85],true);do_preview();function do_preview(Ox27a){if(Ox27a!=OxO9a35[10]&&Ox27a!=null){htmlcode=Ox27a;divpreview[OxO9a35[51]]=Ox27a;return ;} ;divpreview[OxO9a35[51]]=OxO9a35[10];var Ox280=TargetUrl[OxO9a35[11]];if(Ox280==OxO9a35[10]){return ;} ;var Oxc3=Ox280.substring(Ox280.lastIndexOf(OxO9a35[22])).toLowerCase();switch(Oxc3){case OxO9a35[114]:;case OxO9a35[115]:;case OxO9a35[116]:;case OxO9a35[117]:;case OxO9a35[120]:divpreview[OxO9a35[51]]=OxO9a35[118]+Ox280+OxO9a35[119];break ;;case OxO9a35[123]:var Ox3c2=OxO9a35[121]+Ox280+OxO9a35[122];divpreview[OxO9a35[51]]=Ox3c2+OxO9a35[71];break ;;case OxO9a35[124]:;case OxO9a35[125]:;case OxO9a35[126]:;case OxO9a35[129]:var Ox3c3=OxO9a35[127]+Ox280+OxO9a35[128];divpreview[OxO9a35[51]]=Ox3c3+OxO9a35[71];break ;;} ;} ;function do_insert(){element[OxO9a35[47]]=inc_class[OxO9a35[11]];element[OxO9a35[109]]=sel_target[OxO9a35[11]];element[OxO9a35[108]]=inp_title[OxO9a35[11]];if(TargetUrl[OxO9a35[11]]){element[OxO9a35[112]]=TargetUrl[OxO9a35[11]];element.setAttribute(OxO9a35[113],TargetUrl.value);} ;element[OxO9a35[110]]=inp_index[OxO9a35[11]];element[OxO9a35[111]]=inp_access[OxO9a35[11]];element[OxO9a35[48]]=inp_id[OxO9a35[11]];if(element[OxO9a35[108]]==OxO9a35[10]){element.removeAttribute(OxO9a35[108]);} ;if(element[OxO9a35[109]]==OxO9a35[10]){element.removeAttribute(OxO9a35[109]);} ;if(element[OxO9a35[47]]==OxO9a35[10]){element.removeAttribute(OxO9a35[47]);} ;if(element[OxO9a35[47]]==OxO9a35[10]){element.removeAttribute(OxO9a35[107]);} ;if(element[OxO9a35[110]]==OxO9a35[10]){element.removeAttribute(OxO9a35[110]);} ;if(element[OxO9a35[111]]==OxO9a35[10]){element.removeAttribute(OxO9a35[111]);} ;if(element[OxO9a35[48]]==OxO9a35[10]){element.removeAttribute(OxO9a35[48]);} ;try{element[OxO9a35[105]][OxO9a35[104]]=inp_color[OxO9a35[11]];} catch(er){element[OxO9a35[105]][OxO9a35[104]]=OxO9a35[10];} ;var Ox27a=element[OxO9a35[51]];switch(Ox27a.toLowerCase()){case OxO9a35[130]:;case OxO9a35[131]:;case OxO9a35[132]:;case OxO9a35[133]:;case OxO9a35[134]:;case OxO9a35[135]:element[OxO9a35[51]]=OxO9a35[10];break ;;default:break ;;} ;if(element[OxO9a35[51]]==OxO9a35[10]){element[OxO9a35[51]]=element[OxO9a35[108]]||TargetUrl[OxO9a35[11]]||element[OxO9a35[136]]||OxO9a35[10];} ;Window_SetDialogReturnValue(window,element);Window_CloseDialog(window);} ;function do_Close(){Window_SetDialogReturnValue(window,null);Window_CloseDialog(window);} ;function Zoom_In(){if(divpreview[OxO9a35[105]][OxO9a35[137]]!=0){divpreview[OxO9a35[105]][OxO9a35[137]]*=1.2;} else {divpreview[OxO9a35[105]][OxO9a35[137]]=1.2;} ;} ;function Zoom_Out(){if(divpreview[OxO9a35[105]][OxO9a35[137]]!=0){divpreview[OxO9a35[105]][OxO9a35[137]]*=0.8;} else {divpreview[OxO9a35[105]][OxO9a35[137]]=0.8;} ;} ;function Actualsize(){divpreview[OxO9a35[105]][OxO9a35[137]]=1;do_preview();} ;inp_color[OxO9a35[138]]=inp_color_preview[OxO9a35[138]]=function inp_color_onclick(){SelectColor(inp_color,inp_color_preview);} ;if(!Browser_IsWinIE()){btn_zoom_in[OxO9a35[105]][OxO9a35[139]]=btn_zoom_out[OxO9a35[105]][OxO9a35[139]]=btn_Actualsize[OxO9a35[105]][OxO9a35[139]]=OxO9a35[140];inp_color_preview.setAttribute(OxO9a35[141],OxO9a35[142]);} ;if(Browser_IsIE7()){var _dialogPromptID=null;function IEprompt(Ox218,Ox219,Ox21a){that=this;this[OxO9a35[143]]=function (Ox21b){val=document.getElementById(OxO9a35[144])[OxO9a35[11]];_dialogPromptID[OxO9a35[105]][OxO9a35[139]]=OxO9a35[140];document.getElementById(OxO9a35[144])[OxO9a35[11]]=OxO9a35[10];if(Ox21b){val=OxO9a35[10];} ;Ox218(val);return false;} ;if(Ox21a==undefined){Ox21a=OxO9a35[10];} ;if(_dialogPromptID==null){var Ox21c=document.getElementsByTagName(OxO9a35[145])[0];tnode=document.createElement(OxO9a35[146]);tnode[OxO9a35[48]]=OxO9a35[147];Ox21c.appendChild(tnode);_dialogPromptID=document.getElementById(OxO9a35[147]);tnode=document.createElement(OxO9a35[146]);tnode[OxO9a35[48]]=OxO9a35[148];Ox21c.appendChild(tnode);_dialogPromptID[OxO9a35[105]][OxO9a35[149]]=OxO9a35[150];_dialogPromptID[OxO9a35[105]][OxO9a35[106]]=OxO9a35[151];_dialogPromptID[OxO9a35[105]][OxO9a35[152]]=OxO9a35[153];_dialogPromptID[OxO9a35[105]][OxO9a35[154]]=OxO9a35[155];_dialogPromptID[OxO9a35[105]][OxO9a35[156]]=OxO9a35[157];} ;var Ox21d=OxO9a35[158];Ox21d+=OxO9a35[159]+Ox219+OxO9a35[160];Ox21d+=OxO9a35[161];Ox21d+=OxO9a35[162]+Ox21a+OxO9a35[163];Ox21d+=OxO9a35[164];Ox21d+=OxO9a35[165];Ox21d+=OxO9a35[166];Ox21d+=OxO9a35[167];Ox21d+=OxO9a35[168];_dialogPromptID[OxO9a35[51]]=Ox21d;_dialogPromptID[OxO9a35[105]][OxO9a35[0]]=OxO9a35[169];_dialogPromptID[OxO9a35[105]][OxO9a35[170]]=parseInt((document[OxO9a35[145]][OxO9a35[171]]-315)/2)+OxO9a35[172];_dialogPromptID[OxO9a35[105]][OxO9a35[139]]=OxO9a35[173];var Ox21e=document.getElementById(OxO9a35[144]);try{var Ox21f=Ox21e.createTextRange();Ox21f.collapse(false);Ox21f.select();} catch(x){Ox21e.focus();} ;} ;} ;if(CreateDir){CreateDir[OxO9a35[32]]= new Function(OxO9a35[174]);} ;if(Copy){Copy[OxO9a35[32]]= new Function(OxO9a35[174]);} ;if(Move){Move[OxO9a35[32]]= new Function(OxO9a35[174]);} ;if(Delete){Delete[OxO9a35[32]]= new Function(OxO9a35[174]);} ;if(DoRefresh){DoRefresh[OxO9a35[32]]= new Function(OxO9a35[174]);} ;if(btn_zoom_in){btn_zoom_in[OxO9a35[32]]= new Function(OxO9a35[174]);} ;if(btn_zoom_out){btn_zoom_out[OxO9a35[32]]= new Function(OxO9a35[174]);} ;if(btn_Actualsize){btn_Actualsize[OxO9a35[32]]= new Function(OxO9a35[174]);} ;