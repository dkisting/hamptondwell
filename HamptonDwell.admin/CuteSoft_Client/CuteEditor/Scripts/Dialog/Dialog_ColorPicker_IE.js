var OxOdf56=["onerror","onload","onclick","btnCancel","btnOK","onkeyup","txtHSB_Hue","onkeypress","txtHSB_Saturation","txtHSB_Brightness","txtRGB_Red","txtRGB_Green","txtRGB_Blue","txtHex","btnWebSafeColor","rdoHSB_Hue","rdoHSB_Saturation","rdoHSB_Brightness","rdoRGB_Red","rdoRGB_Green","rdoRGB_Blue","onmousemove","onmousedown","onmouseup","{format}","length","\x5C{","\x5C}","BadNumber","A number between {0} and {1} is required. Closest value inserted.","Title","Color Picker","SelectAColor","Select a color:","OKButton","OK","CancelButton","Cancel","AboutButton","About","Recent","WebSafeWarning","Warning: not a web safe color","WebSafeClick","Click to select web safe color","HsbHue","H:","HsbHueTooltip","Hue","HsbHueUnit","%","HsbSaturation","S:","HsbSaturationTooltip","Saturation","HsbSaturationUnit","HsbBrightness","B:","HsbBrightnessTooltip","Brightness","HsbBrightnessUnit","RgbRed","R:","RgbRedTooltip","Red","RgbGreen","G:","RgbGreenTooltip","Green","RgbBlue","RgbBlueTooltip","Blue","Hex","#","RecentTooltip","Recent:","\x0D\x0ALewies Color Pickerversion 1.1\x0D\x0A\x0D\x0AThis form was created by Lewis Moten in May of 2004.\x0D\x0AIt simulates the color picker in a popular graphics application.\x0D\x0AIt gives users a visual way to choose colors from a large and dynamic palette.\x0D\x0A\x0D\x0AVisit the authors web page?\x0D\x0Awww.lewismoten.com\x0D\x0A","UNDEFINED","FFFFFF","value","checked","ColorMode","ColorType","RecentColors","","pnlRecent","all","border","style","0px","backgroundColor","srcElement","display","none","title","innerHTML","backgroundPosition","px ","px","000000","zIndex","01234567879","keyCode","abcdef","01234567879ABCDEF","closeeditordialog","close","returnValue","0123456789ABCDEFabcdef","0","id","pnlGradient_Top","pnlVertical_Top","top","opacity","filters","backgroundImage","url(Load.ashx?type=image\x26file=cpie_GradientPositionDark.gif)","url(Load.ashx?type=image\x26file=cpie_GradientPositionLight.gif)","cancelBubble","clientX","clientY","className","GradientNormal","button","GradientFullScreen","=","; path=/;"," expires=",";","cookie","00336699CCFF","0x","do_select","frm","__cphex"];var POSITIONADJUSTX=21;var POSITIONADJUSTY=46;var POSITIONADJUSTZ=43;var msg= new Object();window[OxOdf56[0]]=alert;var ColorMode=1;var GradientPositionDark= new Boolean(false);var frm= new Object();window[OxOdf56[1]]=window_load;function initialize(){frm[OxOdf56[3]][OxOdf56[2]]=btnCancel_Click;frm[OxOdf56[4]][OxOdf56[2]]=btnOK_Click;frm[OxOdf56[6]][OxOdf56[5]]=Hsb_Changed;frm[OxOdf56[6]][OxOdf56[7]]=validateNumber;frm[OxOdf56[8]][OxOdf56[5]]=Hsb_Changed;frm[OxOdf56[8]][OxOdf56[7]]=validateNumber;frm[OxOdf56[9]][OxOdf56[5]]=Hsb_Changed;frm[OxOdf56[9]][OxOdf56[7]]=validateNumber;frm[OxOdf56[10]][OxOdf56[5]]=Rgb_Changed;frm[OxOdf56[10]][OxOdf56[7]]=validateNumber;frm[OxOdf56[11]][OxOdf56[5]]=Rgb_Changed;frm[OxOdf56[11]][OxOdf56[7]]=validateNumber;frm[OxOdf56[12]][OxOdf56[5]]=Rgb_Changed;frm[OxOdf56[12]][OxOdf56[7]]=validateNumber;frm[OxOdf56[13]][OxOdf56[5]]=Hex_Changed;frm[OxOdf56[13]][OxOdf56[7]]=validateHex;frm[OxOdf56[14]][OxOdf56[2]]=btnWebSafeColor_Click;frm[OxOdf56[15]][OxOdf56[2]]=rdoHsb_Hue_Click;frm[OxOdf56[16]][OxOdf56[2]]=rdoHsb_Saturation_Click;frm[OxOdf56[17]][OxOdf56[2]]=rdoHsb_Brightness_Click;frm[OxOdf56[18]][OxOdf56[2]]=rdoRgb_Red_Click;frm[OxOdf56[19]][OxOdf56[2]]=rdoRgb_Green_Click;frm[OxOdf56[20]][OxOdf56[2]]=rdoRgb_Blue_Click;pnlGradient_Top[OxOdf56[2]]=pnlGradient_Top_Click;pnlGradient_Top[OxOdf56[21]]=pnlGradient_Top_MouseMove;pnlGradient_Top[OxOdf56[22]]=pnlGradient_Top_MouseDown;pnlGradient_Top[OxOdf56[23]]=pnlGradient_Top_MouseUp;pnlVertical_Top[OxOdf56[2]]=pnlVertical_Top_Click;pnlVertical_Top[OxOdf56[21]]=pnlVertical_Top_MouseMove;pnlVertical_Top[OxOdf56[22]]=pnlVertical_Top_MouseDown;pnlVertical_Top[OxOdf56[23]]=pnlVertical_Top_MouseUp;pnlWebSafeColor[OxOdf56[2]]=btnWebSafeColor_Click;pnlWebSafeColorBorder[OxOdf56[2]]=btnWebSafeColor_Click;pnlOldColor[OxOdf56[2]]=pnlOldClick_Click;lblHSB_Hue[OxOdf56[2]]=rdoHsb_Hue_Click;lblHSB_Saturation[OxOdf56[2]]=rdoHsb_Saturation_Click;lblHSB_Brightness[OxOdf56[2]]=rdoHsb_Brightness_Click;lblRGB_Red[OxOdf56[2]]=rdoRgb_Red_Click;lblRGB_Green[OxOdf56[2]]=rdoRgb_Green_Click;lblRGB_Blue[OxOdf56[2]]=rdoRgb_Blue_Click;pnlGradient_Top.focus();} ;function formatString(Ox2aa){if(!Ox2aa){return OxOdf56[24];} ;for(var i=1;i<arguments[OxOdf56[25]];i++){Ox2aa=Ox2aa.replace( new RegExp(OxOdf56[26]+(i-1)+OxOdf56[27]),arguments[i]);} ;return Ox2aa;} ;function AddValue(Ox113,Ox4e){Ox4e=Ox4e.toLowerCase();for(var i=0;i<Ox113[OxOdf56[25]];i++){if(Ox113[i]==Ox4e){return ;} ;} ;Ox113[Ox113[OxOdf56[25]]]=Ox4e;} ;function SniffLanguage(Ox11){} ;function LoadLanguage(){msg[OxOdf56[28]]=OxOdf56[29];msg[OxOdf56[30]]=OxOdf56[31];msg[OxOdf56[32]]=OxOdf56[33];msg[OxOdf56[34]]=OxOdf56[35];msg[OxOdf56[36]]=OxOdf56[37];msg[OxOdf56[38]]=OxOdf56[39];msg[OxOdf56[40]]=OxOdf56[40];msg[OxOdf56[41]]=OxOdf56[42];msg[OxOdf56[43]]=OxOdf56[44];msg[OxOdf56[45]]=OxOdf56[46];msg[OxOdf56[47]]=OxOdf56[48];msg[OxOdf56[49]]=OxOdf56[50];msg[OxOdf56[51]]=OxOdf56[52];msg[OxOdf56[53]]=OxOdf56[54];msg[OxOdf56[55]]=OxOdf56[50];msg[OxOdf56[56]]=OxOdf56[57];msg[OxOdf56[58]]=OxOdf56[59];msg[OxOdf56[60]]=OxOdf56[50];msg[OxOdf56[61]]=OxOdf56[62];msg[OxOdf56[63]]=OxOdf56[64];msg[OxOdf56[65]]=OxOdf56[66];msg[OxOdf56[67]]=OxOdf56[68];msg[OxOdf56[69]]=OxOdf56[57];msg[OxOdf56[70]]=OxOdf56[71];msg[OxOdf56[72]]=OxOdf56[73];msg[OxOdf56[74]]=OxOdf56[75];msg[OxOdf56[39]]=OxOdf56[76];} ;function localize(){} ;function window_load(){frm=frmColorPicker;LoadLanguage();localize();initialize();var hex=OxOdf56[77];if(hex==OxOdf56[77]){hex=OxOdf56[78];} ;if(hex[OxOdf56[25]]==7){hex=hex.substr(1,6);} ;frm[OxOdf56[13]][OxOdf56[79]]=hex;Hex_Changed();hex=Form_Get_Hex();SetBg(pnlOldColor,hex);frm[OxOdf56[82]][ new Number(GetCookie(OxOdf56[81])||0)][OxOdf56[80]]=true;ColorMode_Changed();var Ox2a0=GetCookie(OxOdf56[83])||OxOdf56[84];var Ox2b0=msg[OxOdf56[74]];for(var i=1;i<33;i++){if(Ox2a0[OxOdf56[25]]/6>=i){hex=Ox2a0.substr((i-1)*6,6);var Ox2b1=HexToRgb(hex);var title=formatString(msg.RecentTooltip,hex,Ox2b1[0],Ox2b1[1],Ox2b1[2]);SetBg(document[OxOdf56[86]][OxOdf56[85]+i],hex);SetTitle(document[OxOdf56[86]][OxOdf56[85]+i],title);document[OxOdf56[86]][OxOdf56[85]+i][OxOdf56[2]]=pnlRecent_Click;} else {document[OxOdf56[86]][OxOdf56[85]+i][OxOdf56[88]][OxOdf56[87]]=OxOdf56[89];} ;} ;} ;function pnlRecent_Click(){frm[OxOdf56[13]][OxOdf56[79]]=event[OxOdf56[91]][OxOdf56[88]][OxOdf56[90]].substr(1,6).toUpperCase();Hex_Changed();} ;function pnlOldClick_Click(){frm[OxOdf56[13]][OxOdf56[79]]=pnlOldColor[OxOdf56[88]][OxOdf56[90]].substr(1,6).toUpperCase();Hex_Changed();} ;function rdoHsb_Hue_Click(){frm[OxOdf56[15]][OxOdf56[80]]=true;ColorMode_Changed();} ;function rdoHsb_Saturation_Click(){frm[OxOdf56[16]][OxOdf56[80]]=true;ColorMode_Changed();} ;function rdoHsb_Brightness_Click(){frm[OxOdf56[17]][OxOdf56[80]]=true;ColorMode_Changed();} ;function rdoRgb_Red_Click(){frm[OxOdf56[18]][OxOdf56[80]]=true;ColorMode_Changed();} ;function rdoRgb_Green_Click(){frm[OxOdf56[19]][OxOdf56[80]]=true;ColorMode_Changed();} ;function rdoRgb_Blue_Click(){frm[OxOdf56[20]][OxOdf56[80]]=true;ColorMode_Changed();} ;function Hide(){for(var i=0;i<arguments[OxOdf56[25]];i++){arguments[i][OxOdf56[88]][OxOdf56[92]]=OxOdf56[93];} ;} ;function Show(){for(var i=0;i<arguments[OxOdf56[25]];i++){arguments[i][OxOdf56[88]][OxOdf56[92]]=OxOdf56[84];} ;} ;function SetValue(){for(var i=0;i<arguments[OxOdf56[25]];i+=2){arguments[i][OxOdf56[79]]=arguments[i+1];} ;} ;function SetTitle(){for(var i=0;i<arguments[OxOdf56[25]];i+=2){arguments[i][OxOdf56[94]]=arguments[i+1];} ;} ;function SetHTML(){for(var i=0;i<arguments[OxOdf56[25]];i+=2){arguments[i][OxOdf56[95]]=arguments[i+1];} ;} ;function SetBg(){for(var i=0;i<arguments[OxOdf56[25]];i+=2){arguments[i][OxOdf56[88]][OxOdf56[90]]=OxOdf56[73]+arguments[i+1];} ;} ;function SetBgPosition(){for(var i=0;i<arguments[OxOdf56[25]];i+=3){arguments[i][OxOdf56[88]][OxOdf56[96]]=arguments[i+1]+OxOdf56[97]+arguments[i+2]+OxOdf56[98];} ;} ;function ColorMode_Changed(){for(var i=0;i<6;i++){if(frm[OxOdf56[82]][i][OxOdf56[80]]){ColorMode=i;} ;} ;SetCookie(OxOdf56[81],ColorMode,60*60*24*365);Hide(pnlGradientHsbHue_Hue,pnlGradientHsbHue_Black,pnlGradientHsbHue_White,pnlVerticalHsbHue_Background,pnlVerticalHsbSaturation_Hue,pnlVerticalHsbSaturation_White,pnlVerticalHsbBrightness_Hue,pnlVerticalHsbBrightness_Black,pnlVerticalRgb_Start,pnlVerticalRgb_End,pnlGradientRgb_Base,pnlGradientRgb_Invert,pnlGradientRgb_Overlay1,pnlGradientRgb_Overlay2);switch(ColorMode){case 0:Show(pnlGradientHsbHue_Hue,pnlGradientHsbHue_Black,pnlGradientHsbHue_White,pnlVerticalHsbHue_Background);Hsb_Changed();break ;;case 1:Show(pnlVerticalHsbSaturation_Hue,pnlVerticalHsbSaturation_White,pnlGradientRgb_Base,pnlGradientRgb_Overlay1,pnlGradientRgb_Overlay2);SetBgPosition(pnlGradientRgb_Base,0,0);SetBg(pnlGradientRgb_Overlay1,OxOdf56[78],pnlGradientRgb_Overlay2,OxOdf56[99]);pnlGradientRgb_Overlay1[OxOdf56[88]][OxOdf56[100]]=5;pnlGradientRgb_Overlay2[OxOdf56[88]][OxOdf56[100]]=6;Hsb_Changed();break ;;case 2:Show(pnlVerticalHsbBrightness_Hue,pnlVerticalHsbBrightness_Black,pnlGradientRgb_Base,pnlGradientRgb_Overlay1,pnlGradientRgb_Overlay2);SetBgPosition(pnlGradientRgb_Base,0,0);SetBg(pnlGradientRgb_Overlay1,OxOdf56[99],pnlGradientRgb_Overlay2,OxOdf56[78]);pnlGradientRgb_Overlay1[OxOdf56[88]][OxOdf56[100]]=6;pnlGradientRgb_Overlay2[OxOdf56[88]][OxOdf56[100]]=5;Hsb_Changed();break ;;case 3:Show(pnlVerticalRgb_Start,pnlVerticalRgb_End,pnlGradientRgb_Base,pnlGradientRgb_Invert);SetBgPosition(pnlGradientRgb_Base,256,0,pnlGradientRgb_Invert,256,0);Rgb_Changed();break ;;case 4:Show(pnlVerticalRgb_Start,pnlVerticalRgb_End,pnlGradientRgb_Base,pnlGradientRgb_Invert);SetBgPosition(pnlGradientRgb_Base,0,256,pnlGradientRgb_Invert,0,256);Rgb_Changed();break ;;case 5:Show(pnlVerticalRgb_Start,pnlVerticalRgb_End,pnlGradientRgb_Base,pnlGradientRgb_Invert);SetBgPosition(pnlGradientRgb_Base,256,256,pnlGradientRgb_Invert,256,256);Rgb_Changed();break ;;default:break ;;} ;} ;function btnWebSafeColor_Click(){var Ox2b1=HexToRgb(frm[OxOdf56[13]].value);Ox2b1=RgbToWebSafeRgb(Ox2b1);frm[OxOdf56[13]][OxOdf56[79]]=RgbToHex(Ox2b1);Hex_Changed();} ;function checkWebSafe(){var Ox2b1=Form_Get_Rgb();if(RgbIsWebSafe(Ox2b1)){Hide(frm.btnWebSafeColor,pnlWebSafeColor,pnlWebSafeColorBorder);} else {Ox2b1=RgbToWebSafeRgb(Ox2b1);SetBg(pnlWebSafeColor,RgbToHex(Ox2b1));Show(frm.btnWebSafeColor,pnlWebSafeColor,pnlWebSafeColorBorder);} ;} ;function validateNumber(){var Ox2c6=String.fromCharCode(event.keyCode);if(IgnoreKey()){return ;} ;if(OxOdf56[101].indexOf(Ox2c6)!=-1){return ;} ;event[OxOdf56[102]]=0;} ;function validateHex(){if(IgnoreKey()){return ;} ;var Ox2c6=String.fromCharCode(event.keyCode);if(OxOdf56[103].indexOf(Ox2c6)!=-1){event[OxOdf56[102]]=Ox2c6.toUpperCase().charCodeAt(0);return ;} ;if(OxOdf56[104].indexOf(Ox2c6)!=-1){return ;} ;event[OxOdf56[102]]=0;} ;function IgnoreKey(){var Ox2c6=String.fromCharCode(event.keyCode);var Ox2c9= new Array(0,8,9,13,27);if(Ox2c6==null){return true;} ;for(var i=0;i<5;i++){if(event[OxOdf56[102]]==Ox2c9[i]){return true;} ;} ;return false;} ;function btnCancel_Click(){(top[OxOdf56[105]]||top[OxOdf56[106]])();} ;function btnOK_Click(){var hex= new String(frm[OxOdf56[13]].value);try{window[OxOdf56[107]]=hex;} catch(e){} ;recent=GetCookie(OxOdf56[83])||OxOdf56[84];for(var i=0;i<recent[OxOdf56[25]];i+=6){if(recent.substr(i,6)==hex){recent=recent.substr(0,i)+recent.substr(i+6);i-=6;} ;} ;if(recent[OxOdf56[25]]>31*6){recent=recent.substr(0,31*6);} ;recent=frm[OxOdf56[13]][OxOdf56[79]]+recent;SetCookie(OxOdf56[83],recent,60*60*24*365);(top[OxOdf56[105]]||top[OxOdf56[106]])();} ;function SetGradientPosition(x,y){x=x-POSITIONADJUSTX+5;y=y-POSITIONADJUSTY+5;x-=7;y-=27;x=x<0?0:x>255?255:x;y=y<0?0:y>255?255:y;SetBgPosition(pnlGradientPosition,x-5,y-5);switch(ColorMode){case 0:var Ox2cd= new Array(0,0,0);Ox2cd[1]=x/255;Ox2cd[2]=1-(y/255);frm[OxOdf56[8]][OxOdf56[79]]=Math.round(Ox2cd[1]*100);frm[OxOdf56[9]][OxOdf56[79]]=Math.round(Ox2cd[2]*100);Hsb_Changed();break ;;case 1:var Ox2cd= new Array(0,0,0);Ox2cd[0]=x/255;Ox2cd[2]=1-(y/255);frm[OxOdf56[6]][OxOdf56[79]]=Ox2cd[0]==1?0:Math.round(Ox2cd[0]*360);frm[OxOdf56[9]][OxOdf56[79]]=Math.round(Ox2cd[2]*100);Hsb_Changed();break ;;case 2:var Ox2cd= new Array(0,0,0);Ox2cd[0]=x/255;Ox2cd[1]=1-(y/255);frm[OxOdf56[6]][OxOdf56[79]]=Ox2cd[0]==1?0:Math.round(Ox2cd[0]*360);frm[OxOdf56[8]][OxOdf56[79]]=Math.round(Ox2cd[1]*100);Hsb_Changed();break ;;case 3:var Ox2b1= new Array(0,0,0);Ox2b1[1]=255-y;Ox2b1[2]=x;frm[OxOdf56[11]][OxOdf56[79]]=Ox2b1[1];frm[OxOdf56[12]][OxOdf56[79]]=Ox2b1[2];Rgb_Changed();break ;;case 4:var Ox2b1= new Array(0,0,0);Ox2b1[0]=255-y;Ox2b1[2]=x;frm[OxOdf56[10]][OxOdf56[79]]=Ox2b1[0];frm[OxOdf56[12]][OxOdf56[79]]=Ox2b1[2];Rgb_Changed();break ;;case 5:var Ox2b1= new Array(0,0,0);Ox2b1[0]=x;Ox2b1[1]=255-y;frm[OxOdf56[10]][OxOdf56[79]]=Ox2b1[0];frm[OxOdf56[11]][OxOdf56[79]]=Ox2b1[1];Rgb_Changed();break ;;} ;} ;function Hex_Changed(){var hex=Form_Get_Hex();var Ox2b1=HexToRgb(hex);var Ox2cd=RgbToHsb(Ox2b1);Form_Set_Rgb(Ox2b1);Form_Set_Hsb(Ox2cd);SetBg(pnlNewColor,hex);SetupCursors();SetupGradients();checkWebSafe();} ;function Rgb_Changed(){var Ox2b1=Form_Get_Rgb();var Ox2cd=RgbToHsb(Ox2b1);var hex=RgbToHex(Ox2b1);Form_Set_Hsb(Ox2cd);Form_Set_Hex(hex);SetBg(pnlNewColor,hex);SetupCursors();SetupGradients();checkWebSafe();} ;function Hsb_Changed(){var Ox2cd=Form_Get_Hsb();var Ox2b1=HsbToRgb(Ox2cd);var hex=RgbToHex(Ox2b1);Form_Set_Rgb(Ox2b1);Form_Set_Hex(hex);SetBg(pnlNewColor,hex);SetupCursors();SetupGradients();checkWebSafe();} ;function Form_Set_Hex(hex){frm[OxOdf56[13]][OxOdf56[79]]=hex;} ;function Form_Get_Hex(){var hex= new String(frm[OxOdf56[13]].value);for(var i=0;i<hex[OxOdf56[25]];i++){if(OxOdf56[108].indexOf(hex.substr(i,1))==-1){hex=OxOdf56[99];frm[OxOdf56[13]][OxOdf56[79]]=hex;alert(formatString(msg.BadNumber,OxOdf56[99],OxOdf56[78]));break ;} ;} ;while(hex[OxOdf56[25]]<6){hex=OxOdf56[109]+hex;} ;return hex;} ;function Form_Get_Hsb(){var Ox2cd= new Array(0,0,0);Ox2cd[0]= new Number(frm[OxOdf56[6]].value)/360;Ox2cd[1]= new Number(frm[OxOdf56[8]].value)/100;Ox2cd[2]= new Number(frm[OxOdf56[9]].value)/100;if(Ox2cd[0]>1||isNaN(Ox2cd[0])){Ox2cd[0]=1;frm[OxOdf56[6]][OxOdf56[79]]=360;alert(formatString(msg.BadNumber,0,360));} ;if(Ox2cd[1]>1||isNaN(Ox2cd[1])){Ox2cd[1]=1;frm[OxOdf56[8]][OxOdf56[79]]=100;alert(formatString(msg.BadNumber,0,100));} ;if(Ox2cd[2]>1||isNaN(Ox2cd[2])){Ox2cd[2]=1;frm[OxOdf56[9]][OxOdf56[79]]=100;alert(formatString(msg.BadNumber,0,100));} ;return Ox2cd;} ;function Form_Set_Hsb(Ox2cd){SetValue(frm.txtHSB_Hue,Math.round(Ox2cd[0]*360),frm.txtHSB_Saturation,Math.round(Ox2cd[1]*100),frm.txtHSB_Brightness,Math.round(Ox2cd[2]*100));} ;function Form_Get_Rgb(){var Ox2b1= new Array(0,0,0);Ox2b1[0]= new Number(frm[OxOdf56[10]].value);Ox2b1[1]= new Number(frm[OxOdf56[11]].value);Ox2b1[2]= new Number(frm[OxOdf56[12]].value);if(Ox2b1[0]>255||isNaN(Ox2b1[0])||Ox2b1[0]!=Math.round(Ox2b1[0])){Ox2b1[0]=255;frm[OxOdf56[10]][OxOdf56[79]]=255;alert(formatString(msg.BadNumber,0,255));} ;if(Ox2b1[1]>255||isNaN(Ox2b1[1])||Ox2b1[1]!=Math.round(Ox2b1[1])){Ox2b1[1]=255;frm[OxOdf56[11]][OxOdf56[79]]=255;alert(formatString(msg.BadNumber,0,255));} ;if(Ox2b1[2]>255||isNaN(Ox2b1[2])||Ox2b1[2]!=Math.round(Ox2b1[2])){Ox2b1[2]=255;frm[OxOdf56[12]][OxOdf56[79]]=255;alert(formatString(msg.BadNumber,0,255));} ;return Ox2b1;} ;function Form_Set_Rgb(Ox2b1){frm[OxOdf56[10]][OxOdf56[79]]=Ox2b1[0];frm[OxOdf56[11]][OxOdf56[79]]=Ox2b1[1];frm[OxOdf56[12]][OxOdf56[79]]=Ox2b1[2];} ;function SetupCursors(){var Ox2cd=Form_Get_Hsb();var Ox2b1=Form_Get_Rgb();if(RgbToYuv(Ox2b1)[0]>=0.5){SetGradientPositionDark();} else {SetGradientPositionLight();} ;if(event[OxOdf56[91]]!=null){if(event[OxOdf56[91]][OxOdf56[110]]==OxOdf56[111]){return ;} ;if(event[OxOdf56[91]][OxOdf56[110]]==OxOdf56[112]){return ;} ;} ;var x;var y;var z;if(ColorMode>=0&&ColorMode<=2){for(var i=0;i<3;i++){Ox2cd[i]*=255;} ;} ;switch(ColorMode){case 0:x=Ox2cd[1];y=Ox2cd[2];z=Ox2cd[0]==0?1:Ox2cd[0];break ;;case 1:x=Ox2cd[0]==0?1:Ox2cd[0];y=Ox2cd[2];z=Ox2cd[1];break ;;case 2:x=Ox2cd[0]==0?1:Ox2cd[0];y=Ox2cd[1];z=Ox2cd[2];break ;;case 3:x=Ox2b1[2];y=Ox2b1[1];z=Ox2b1[0];break ;;case 4:x=Ox2b1[2];y=Ox2b1[0];z=Ox2b1[1];break ;;case 5:x=Ox2b1[0];y=Ox2b1[1];z=Ox2b1[2];break ;;} ;y=255-y;z=255-z;SetBgPosition(pnlGradientPosition,x-5,y-5);pnlVerticalPosition[OxOdf56[88]][OxOdf56[113]]=(z+27)+OxOdf56[98];} ;function SetupGradients(){var Ox2cd=Form_Get_Hsb();var Ox2b1=Form_Get_Rgb();switch(ColorMode){case 0:SetBg(pnlGradientHsbHue_Hue,RgbToHex(HueToRgb(Ox2cd[0])));break ;;case 1:var b= new Array();for(var i=0;i<3;i++){b[i]=Math.round(Ox2cd[2]*255);} ;SetBg(pnlGradientHsbHue_Hue,RgbToHex(HueToRgb(Ox2cd[0])),pnlVerticalHsbSaturation_Hue,RgbToHex(HsbToRgb( new Array(Ox2cd[0],1,Ox2cd[2]))),pnlVerticalHsbSaturation_White,RgbToHex(b));pnlGradientRgb_Overlay1[OxOdf56[115]][0][OxOdf56[114]]=(100-Math.round(Ox2cd[1]*100));break ;;case 2:SetBg(pnlVerticalHsbBrightness_Hue,RgbToHex(HsbToRgb( new Array(Ox2cd[0],Ox2cd[1],1))));pnlGradientRgb_Overlay1[OxOdf56[115]][0][OxOdf56[114]]=(100-Math.round(Ox2cd[2]*100));break ;;case 3:pnlGradientRgb_Invert[OxOdf56[115]][3][OxOdf56[114]]=100-Math.round((Ox2b1[0]/255)*100);SetBg(pnlVerticalRgb_Start,RgbToHex( new Array(0xFF,Ox2b1[1],Ox2b1[2])),pnlVerticalRgb_End,RgbToHex( new Array(0x00,Ox2b1[1],Ox2b1[2])));break ;;case 4:pnlGradientRgb_Invert[OxOdf56[115]][3][OxOdf56[114]]=100-Math.round((Ox2b1[1]/255)*100);SetBg(pnlVerticalRgb_Start,RgbToHex( new Array(Ox2b1[0],0xFF,Ox2b1[2])),pnlVerticalRgb_End,RgbToHex( new Array(Ox2b1[0],0x00,Ox2b1[2])));break ;;case 5:pnlGradientRgb_Invert[OxOdf56[115]][3][OxOdf56[114]]=100-Math.round((Ox2b1[2]/255)*100);SetBg(pnlVerticalRgb_Start,RgbToHex( new Array(Ox2b1[0],Ox2b1[1],0xFF)),pnlVerticalRgb_End,RgbToHex( new Array(Ox2b1[0],Ox2b1[1],0x00)));break ;;default:;} ;} ;function SetGradientPositionDark(){if(GradientPositionDark){return ;} ;GradientPositionDark=true;pnlGradientPosition[OxOdf56[88]][OxOdf56[116]]=OxOdf56[117];} ;function SetGradientPositionLight(){if(!GradientPositionDark){return ;} ;GradientPositionDark=false;pnlGradientPosition[OxOdf56[88]][OxOdf56[116]]=OxOdf56[118];} ;function pnlGradient_Top_Click(){event[OxOdf56[119]]=true;SetGradientPosition(event[OxOdf56[120]]-5,event[OxOdf56[121]]-5);pnlGradient_Top[OxOdf56[122]]=OxOdf56[123];} ;function pnlGradient_Top_MouseMove(){event[OxOdf56[119]]=true;if(event[OxOdf56[124]]!=1){return ;} ;SetGradientPosition(event[OxOdf56[120]]-5,event[OxOdf56[121]]-5);} ;function pnlGradient_Top_MouseDown(){event[OxOdf56[119]]=true;SetGradientPosition(event[OxOdf56[120]]-5,event[OxOdf56[121]]-5);pnlGradient_Top[OxOdf56[122]]=OxOdf56[125];} ;function pnlGradient_Top_MouseUp(){event[OxOdf56[119]]=true;SetGradientPosition(event[OxOdf56[120]]-5,event[OxOdf56[121]]-5);pnlGradient_Top[OxOdf56[122]]=OxOdf56[123];} ;function Document_MouseUp(){event[OxOdf56[119]]=true;pnlGradient_Top[OxOdf56[122]]=OxOdf56[123];} ;function SetVerticalPosition(z){var z=z-POSITIONADJUSTZ;if(z<27){z=27;} ;if(z>282){z=282;} ;pnlVerticalPosition[OxOdf56[88]][OxOdf56[113]]=z+OxOdf56[98];z=1-((z-27)/255);switch(ColorMode){case 0:if(z==1){z=0;} ;frm[OxOdf56[6]][OxOdf56[79]]=Math.round(z*360);Hsb_Changed();break ;;case 1:frm[OxOdf56[8]][OxOdf56[79]]=Math.round(z*100);Hsb_Changed();break ;;case 2:frm[OxOdf56[9]][OxOdf56[79]]=Math.round(z*100);Hsb_Changed();break ;;case 3:frm[OxOdf56[10]][OxOdf56[79]]=Math.round(z*255);Rgb_Changed();break ;;case 4:frm[OxOdf56[11]][OxOdf56[79]]=Math.round(z*255);Rgb_Changed();break ;;case 5:frm[OxOdf56[12]][OxOdf56[79]]=Math.round(z*255);Rgb_Changed();break ;;} ;} ;function pnlVertical_Top_Click(){SetVerticalPosition(event[OxOdf56[121]]-5);event[OxOdf56[119]]=true;} ;function pnlVertical_Top_MouseMove(){if(event[OxOdf56[124]]!=1){return ;} ;SetVerticalPosition(event[OxOdf56[121]]-5);event[OxOdf56[119]]=true;} ;function pnlVertical_Top_MouseDown(){SetVerticalPosition(event[OxOdf56[121]]-5);event[OxOdf56[119]]=true;} ;function pnlVertical_Top_MouseUp(){SetVerticalPosition(event[OxOdf56[121]]-5);event[OxOdf56[119]]=true;} ;function SetCookie(name,Ox4e,Ox4f){var Ox50=name+OxOdf56[126]+escape(Ox4e)+OxOdf56[127];if(Ox4f){var Ox51= new Date();Ox51.setSeconds(Ox51.getSeconds()+Ox4f);Ox50+=OxOdf56[128]+Ox51.toUTCString()+OxOdf56[129];} ;document[OxOdf56[130]]=Ox50;} ;function GetCookie(name){var Ox53=document[OxOdf56[130]].split(OxOdf56[129]);for(var i=0;i<Ox53[OxOdf56[25]];i++){var Ox54=Ox53[i].split(OxOdf56[126]);if(name==Ox54[0].replace(/\s/g,OxOdf56[84])){return unescape(Ox54[1]);} ;} ;} ;function GetCookieDictionary(){var Ox124={};var Ox53=document[OxOdf56[130]].split(OxOdf56[129]);for(var i=0;i<Ox53[OxOdf56[25]];i++){var Ox54=Ox53[i].split(OxOdf56[126]);Ox124[Ox54[0].replace(/\s/g,OxOdf56[84])]=unescape(Ox54[1]);} ;return Ox124;} ;function RgbIsWebSafe(Ox2b1){var hex=RgbToHex(Ox2b1);for(var i=0;i<3;i++){if(OxOdf56[131].indexOf(hex.substr(i*2,2))==-1){return false;} ;} ;return true;} ;function RgbToWebSafeRgb(Ox2b1){var Ox2e7= new Array(Ox2b1[0],Ox2b1[1],Ox2b1[2]);if(RgbIsWebSafe(Ox2b1)){return Ox2e7;} ;var Ox2e8= new Array(0x00,0x33,0x66,0x99,0xCC,0xFF);for(var i=0;i<3;i++){for(var j=1;j<6;j++){if(Ox2e7[i]>Ox2e8[j-1]&&Ox2e7[i]<Ox2e8[j]){if(Ox2e7[i]-Ox2e8[j-1]>Ox2e8[j]-Ox2e7[i]){Ox2e7[i]=Ox2e8[j];} else {Ox2e7[i]=Ox2e8[j-1];} ;break ;} ;} ;} ;return Ox2e7;} ;function RgbToYuv(Ox2b1){var Ox2ea= new Array();Ox2ea[0]=(Ox2b1[0]*0.299+Ox2b1[1]*0.587+Ox2b1[2]*0.114)/255;Ox2ea[1]=(Ox2b1[0]*-0.169+Ox2b1[1]*-0.332+Ox2b1[2]*0.500+128)/255;Ox2ea[2]=(Ox2b1[0]*0.500+Ox2b1[1]*-0.419+Ox2b1[2]*-0.0813+128)/255;return Ox2ea;} ;function RgbToHsb(Ox2b1){var Ox2ec= new Array(Ox2b1[0],Ox2b1[1],Ox2b1[2]);var Ox2ed= new Number(1);var Ox2ee= new Number(0);var Ox2ef= new Number(1);var Ox2cd= new Array(0,0,0);var Ox2f0= new Array();for(var i=0;i<3;i++){Ox2ec[i]=Ox2b1[i]/255;if(Ox2ec[i]<Ox2ed){Ox2ed=Ox2ec[i];} ;if(Ox2ec[i]>Ox2ee){Ox2ee=Ox2ec[i];} ;} ;Ox2ef=Ox2ee-Ox2ed;Ox2cd[2]=Ox2ee;if(Ox2ef==0){return Ox2cd;} ;Ox2cd[1]=Ox2ef/Ox2ee;for(var i=0;i<3;i++){Ox2f0[i]=(((Ox2ee-Ox2ec[i])/6)+(Ox2ef/2))/Ox2ef;} ;if(Ox2ec[0]==Ox2ee){Ox2cd[0]=Ox2f0[2]-Ox2f0[1];} else {if(Ox2ec[1]==Ox2ee){Ox2cd[0]=(1/3)+Ox2f0[0]-Ox2f0[2];} else {if(Ox2ec[2]==Ox2ee){Ox2cd[0]=(2/3)+Ox2f0[1]-Ox2f0[0];} ;} ;} ;if(Ox2cd[0]<0){Ox2cd[0]+=1;} else {if(Ox2cd[0]>1){Ox2cd[0]-=1;} ;} ;return Ox2cd;} ;function HsbToRgb(Ox2cd){var Ox2b1=HueToRgb(Ox2cd[0]);var Ox119=Ox2cd[2]*255;for(var i=0;i<3;i++){Ox2b1[i]=Ox2b1[i]*Ox2cd[2];Ox2b1[i]=((Ox2b1[i]-Ox119)*Ox2cd[1])+Ox119;Ox2b1[i]=Math.round(Ox2b1[i]);} ;return Ox2b1;} ;function RgbToHex(Ox2b1){var hex= new String();for(var i=0;i<3;i++){Ox2b1[2-i]=Math.round(Ox2b1[2-i]);hex=Ox2b1[2-i].toString(16)+hex;if(hex[OxOdf56[25]]%2==1){hex=OxOdf56[109]+hex;} ;} ;return hex.toUpperCase();} ;function HexToRgb(hex){var Ox2b1= new Array();for(var i=0;i<3;i++){Ox2b1[i]= new Number(OxOdf56[132]+hex.substr(i*2,2));} ;return Ox2b1;} ;function HueToRgb(Ox2f5){var Ox2f6=Ox2f5*360;var Ox2b1= new Array(0,0,0);var Ox2f7=(Ox2f6%60)/60;if(Ox2f6<60){Ox2b1[0]=255;Ox2b1[1]=Ox2f7*255;} else {if(Ox2f6<120){Ox2b1[1]=255;Ox2b1[0]=(1-Ox2f7)*255;} else {if(Ox2f6<180){Ox2b1[1]=255;Ox2b1[2]=Ox2f7*255;} else {if(Ox2f6<240){Ox2b1[2]=255;Ox2b1[1]=(1-Ox2f7)*255;} else {if(Ox2f6<300){Ox2b1[2]=255;Ox2b1[0]=Ox2f7*255;} else {if(Ox2f6<360){Ox2b1[0]=255;Ox2b1[2]=(1-Ox2f7)*255;} ;} ;} ;} ;} ;} ;return Ox2b1;} ;function CheckHexSelect(){if(window[OxOdf56[133]]&&window[OxOdf56[134]]&&frm[OxOdf56[13]]){var Oxd5=OxOdf56[73]+frm[OxOdf56[13]][OxOdf56[79]];if(Oxd5[OxOdf56[25]]==7){if(window[OxOdf56[135]]!=Oxd5){window[OxOdf56[135]]=Oxd5;window.do_select(Oxd5);} ;} ;} ;} ;setInterval(CheckHexSelect,10);