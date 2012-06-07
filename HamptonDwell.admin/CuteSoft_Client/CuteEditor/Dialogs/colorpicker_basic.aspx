<%@ Page Language="C#" Inherits="CuteEditor.EditorUtilityPage" %>
<script runat="server">
string GetDialogQueryString;
override protected void OnInit(EventArgs args)
{
	if(Context.Request.QueryString["Dialog"]=="Standard")
	{	
	if(Context.Request.QueryString["IsFrame"]==null)
	{
		string FrameSrc="colorpicker_basic.aspx?IsFrame=1&"+Request.ServerVariables["QUERY_STRING"];
		CuteEditor.CEU.WriteDialogOuterFrame(Context,"[[MoreColors]]",FrameSrc);
		Context.Response.End();
	}
	}
	string s="";
	if(Context.Request.QueryString["Dialog"]=="Standard")	
		s="&Dialog=Standard";
	
	GetDialogQueryString="Theme="+Context.Request.QueryString["Theme"]+s;	
	base.OnInit(args);
}
</script>
<html xmlns="http://www.w3.org/1999/xhtml">
	<head runat="server">
		<meta http-equiv="Page-Enter" content="blendTrans(Duration=0.1)" />
		<meta http-equiv="Page-Exit" content="blendTrans(Duration=0.1)" />
		<script type="text/javascript" src="Load.ashx?type=dialogscript&verfix=1002&file=DialogHead.js"></script>
		<script type="text/javascript" src="Load.ashx?type=dialogscript&verfix=1002&file=Dialog_ColorPicker.js"></script>
		<link href='Load.ashx?type=themecss&file=dialog.css&theme=[[_Theme_]]' type="text/css"
			rel="stylesheet" />
		<style type="text/css">
			.colorcell
			{
				width:16px;
				height:17px;
				cursor:hand;
			}
			.colordiv,.customdiv
			{
				border:solid 1px #808080;
				width:16px;
				height:17px;
				font-size:1px;
			}
		</style>
		<title>[[NamedColors]]</title>
		<script>
								
		var OxO3a17=["Green","#008000","Lime","#00FF00","Teal","#008080","Aqua","#00FFFF","Navy","#000080","Blue","#0000FF","Purple","#800080","Fuchsia","#FF00FF","Maroon","#800000","Red","#FF0000","Olive","#808000","Yellow","#FFFF00","White","#FFFFFF","Silver","#C0C0C0","Gray","#808080","Black","#000000","DarkOliveGreen","#556B2F","DarkGreen","#006400","DarkSlateGray","#2F4F4F","SlateGray","#708090","DarkBlue","#00008B","MidnightBlue","#191970","Indigo","#4B0082","DarkMagenta","#8B008B","Brown","#A52A2A","DarkRed","#8B0000","Sienna","#A0522D","SaddleBrown","#8B4513","DarkGoldenrod","#B8860B","Beige","#F5F5DC","HoneyDew","#F0FFF0","DimGray","#696969","OliveDrab","#6B8E23","ForestGreen","#228B22","DarkCyan","#008B8B","LightSlateGray","#778899","MediumBlue","#0000CD","DarkSlateBlue","#483D8B","DarkViolet","#9400D3","MediumVioletRed","#C71585","IndianRed","#CD5C5C","Firebrick","#B22222","Chocolate","#D2691E","Peru","#CD853F","Goldenrod","#DAA520","LightGoldenrodYellow","#FAFAD2","MintCream","#F5FFFA","DarkGray","#A9A9A9","YellowGreen","#9ACD32","SeaGreen","#2E8B57","CadetBlue","#5F9EA0","SteelBlue","#4682B4","RoyalBlue","#4169E1","BlueViolet","#8A2BE2","DarkOrchid","#9932CC","DeepPink","#FF1493","RosyBrown","#BC8F8F","Crimson","#DC143C","DarkOrange","#FF8C00","BurlyWood","#DEB887","DarkKhaki","#BDB76B","LightYellow","#FFFFE0","Azure","#F0FFFF","LightGray","#D3D3D3","LawnGreen","#7CFC00","MediumSeaGreen","#3CB371","LightSeaGreen","#20B2AA","DeepSkyBlue","#00BFFF","DodgerBlue","#1E90FF","SlateBlue","#6A5ACD","MediumOrchid","#BA55D3","PaleVioletRed","#DB7093","Salmon","#FA8072","OrangeRed","#FF4500","SandyBrown","#F4A460","Tan","#D2B48C","Gold","#FFD700","Ivory","#FFFFF0","GhostWhite","#F8F8FF","Gainsboro","#DCDCDC","Chartreuse","#7FFF00","LimeGreen","#32CD32","MediumAquamarine","#66CDAA","DarkTurquoise","#00CED1","CornflowerBlue","#6495ED","MediumSlateBlue","#7B68EE","Orchid","#DA70D6","HotPink","#FF69B4","LightCoral","#F08080","Tomato","#FF6347","Orange","#FFA500","Bisque","#FFE4C4","Khaki","#F0E68C","Cornsilk","#FFF8DC","Linen","#FAF0E6","WhiteSmoke","#F5F5F5","GreenYellow","#ADFF2F","DarkSeaGreen","#8FBC8B","Turquoise","#40E0D0","MediumTurquoise","#48D1CC","SkyBlue","#87CEEB","MediumPurple","#9370DB","Violet","#EE82EE","LightPink","#FFB6C1","DarkSalmon","#E9967A","Coral","#FF7F50","NavajoWhite","#FFDEAD","BlanchedAlmond","#FFEBCD","PaleGoldenrod","#EEE8AA","Oldlace","#FDF5E6","Seashell","#FFF5EE","PaleGreen","#98FB98","SpringGreen","#00FF7F","Aquamarine","#7FFFD4","PowderBlue","#B0E0E6","LightSkyBlue","#87CEFA","LightSteelBlue","#B0C4DE","Plum","#DDA0DD","Pink","#FFC0CB","LightSalmon","#FFA07A","Wheat","#F5DEB3","Moccasin","#FFE4B5","AntiqueWhite","#FAEBD7","LemonChiffon","#FFFACD","FloralWhite","#FFFAF0","Snow","#FFFAFA","AliceBlue","#F0F8FF","LightGreen","#90EE90","MediumSpringGreen","#00FA9A","PaleTurquoise","#AFEEEE","LightCyan","#E0FFFF","LightBlue","#ADD8E6","Lavender","#E6E6FA","Thistle","#D8BFD8","MistyRose","#FFE4E1","Peachpuff","#FFDAB9","PapayaWhip","#FFEFD5"];var colorlist=[{n:OxO3a17[0],h:OxO3a17[1]},{n:OxO3a17[2],h:OxO3a17[3]},{n:OxO3a17[4],h:OxO3a17[5]},{n:OxO3a17[6],h:OxO3a17[7]},{n:OxO3a17[8],h:OxO3a17[9]},{n:OxO3a17[10],h:OxO3a17[11]},{n:OxO3a17[12],h:OxO3a17[13]},{n:OxO3a17[14],h:OxO3a17[15]},{n:OxO3a17[16],h:OxO3a17[17]},{n:OxO3a17[18],h:OxO3a17[19]},{n:OxO3a17[20],h:OxO3a17[21]},{n:OxO3a17[22],h:OxO3a17[23]},{n:OxO3a17[24],h:OxO3a17[25]},{n:OxO3a17[26],h:OxO3a17[27]},{n:OxO3a17[28],h:OxO3a17[29]},{n:OxO3a17[30],h:OxO3a17[31]}];var colormore=[{n:OxO3a17[32],h:OxO3a17[33]},{n:OxO3a17[34],h:OxO3a17[35]},{n:OxO3a17[36],h:OxO3a17[37]},{n:OxO3a17[38],h:OxO3a17[39]},{n:OxO3a17[40],h:OxO3a17[41]},{n:OxO3a17[42],h:OxO3a17[43]},{n:OxO3a17[44],h:OxO3a17[45]},{n:OxO3a17[46],h:OxO3a17[47]},{n:OxO3a17[48],h:OxO3a17[49]},{n:OxO3a17[50],h:OxO3a17[51]},{n:OxO3a17[52],h:OxO3a17[53]},{n:OxO3a17[54],h:OxO3a17[55]},{n:OxO3a17[56],h:OxO3a17[57]},{n:OxO3a17[58],h:OxO3a17[59]},{n:OxO3a17[60],h:OxO3a17[61]},{n:OxO3a17[62],h:OxO3a17[63]},{n:OxO3a17[64],h:OxO3a17[65]},{n:OxO3a17[66],h:OxO3a17[67]},{n:OxO3a17[68],h:OxO3a17[69]},{n:OxO3a17[70],h:OxO3a17[71]},{n:OxO3a17[72],h:OxO3a17[73]},{n:OxO3a17[74],h:OxO3a17[75]},{n:OxO3a17[76],h:OxO3a17[77]},{n:OxO3a17[78],h:OxO3a17[79]},{n:OxO3a17[80],h:OxO3a17[81]},{n:OxO3a17[82],h:OxO3a17[83]},{n:OxO3a17[84],h:OxO3a17[85]},{n:OxO3a17[86],h:OxO3a17[87]},{n:OxO3a17[88],h:OxO3a17[89]},{n:OxO3a17[90],h:OxO3a17[91]},{n:OxO3a17[92],h:OxO3a17[93]},{n:OxO3a17[94],h:OxO3a17[95]},{n:OxO3a17[96],h:OxO3a17[97]},{n:OxO3a17[98],h:OxO3a17[99]},{n:OxO3a17[100],h:OxO3a17[101]},{n:OxO3a17[102],h:OxO3a17[103]},{n:OxO3a17[104],h:OxO3a17[105]},{n:OxO3a17[106],h:OxO3a17[107]},{n:OxO3a17[108],h:OxO3a17[109]},{n:OxO3a17[110],h:OxO3a17[111]},{n:OxO3a17[112],h:OxO3a17[113]},{n:OxO3a17[114],h:OxO3a17[115]},{n:OxO3a17[116],h:OxO3a17[117]},{n:OxO3a17[118],h:OxO3a17[119]},{n:OxO3a17[120],h:OxO3a17[121]},{n:OxO3a17[122],h:OxO3a17[123]},{n:OxO3a17[124],h:OxO3a17[125]},{n:OxO3a17[126],h:OxO3a17[127]},{n:OxO3a17[128],h:OxO3a17[129]},{n:OxO3a17[130],h:OxO3a17[131]},{n:OxO3a17[132],h:OxO3a17[133]},{n:OxO3a17[134],h:OxO3a17[135]},{n:OxO3a17[136],h:OxO3a17[137]},{n:OxO3a17[138],h:OxO3a17[139]},{n:OxO3a17[140],h:OxO3a17[141]},{n:OxO3a17[142],h:OxO3a17[143]},{n:OxO3a17[144],h:OxO3a17[145]},{n:OxO3a17[146],h:OxO3a17[147]},{n:OxO3a17[148],h:OxO3a17[149]},{n:OxO3a17[150],h:OxO3a17[151]},{n:OxO3a17[152],h:OxO3a17[153]},{n:OxO3a17[154],h:OxO3a17[155]},{n:OxO3a17[156],h:OxO3a17[157]},{n:OxO3a17[158],h:OxO3a17[159]},{n:OxO3a17[160],h:OxO3a17[161]},{n:OxO3a17[162],h:OxO3a17[163]},{n:OxO3a17[164],h:OxO3a17[165]},{n:OxO3a17[166],h:OxO3a17[167]},{n:OxO3a17[168],h:OxO3a17[169]},{n:OxO3a17[170],h:OxO3a17[171]},{n:OxO3a17[172],h:OxO3a17[173]},{n:OxO3a17[174],h:OxO3a17[175]},{n:OxO3a17[176],h:OxO3a17[177]},{n:OxO3a17[178],h:OxO3a17[179]},{n:OxO3a17[180],h:OxO3a17[181]},{n:OxO3a17[182],h:OxO3a17[183]},{n:OxO3a17[184],h:OxO3a17[185]},{n:OxO3a17[186],h:OxO3a17[187]},{n:OxO3a17[188],h:OxO3a17[189]},{n:OxO3a17[190],h:OxO3a17[191]},{n:OxO3a17[192],h:OxO3a17[193]},{n:OxO3a17[194],h:OxO3a17[195]},{n:OxO3a17[196],h:OxO3a17[197]},{n:OxO3a17[198],h:OxO3a17[199]},{n:OxO3a17[200],h:OxO3a17[201]},{n:OxO3a17[202],h:OxO3a17[203]},{n:OxO3a17[204],h:OxO3a17[205]},{n:OxO3a17[206],h:OxO3a17[207]},{n:OxO3a17[208],h:OxO3a17[209]},{n:OxO3a17[210],h:OxO3a17[211]},{n:OxO3a17[212],h:OxO3a17[213]},{n:OxO3a17[214],h:OxO3a17[215]},{n:OxO3a17[216],h:OxO3a17[217]},{n:OxO3a17[218],h:OxO3a17[219]},{n:OxO3a17[220],h:OxO3a17[221]},{n:OxO3a17[156],h:OxO3a17[157]},{n:OxO3a17[222],h:OxO3a17[223]},{n:OxO3a17[224],h:OxO3a17[225]},{n:OxO3a17[226],h:OxO3a17[227]},{n:OxO3a17[228],h:OxO3a17[229]},{n:OxO3a17[230],h:OxO3a17[231]},{n:OxO3a17[232],h:OxO3a17[233]},{n:OxO3a17[234],h:OxO3a17[235]},{n:OxO3a17[236],h:OxO3a17[237]},{n:OxO3a17[238],h:OxO3a17[239]},{n:OxO3a17[240],h:OxO3a17[241]},{n:OxO3a17[242],h:OxO3a17[243]},{n:OxO3a17[244],h:OxO3a17[245]},{n:OxO3a17[246],h:OxO3a17[247]},{n:OxO3a17[248],h:OxO3a17[249]},{n:OxO3a17[250],h:OxO3a17[251]},{n:OxO3a17[252],h:OxO3a17[253]},{n:OxO3a17[254],h:OxO3a17[255]},{n:OxO3a17[256],h:OxO3a17[257]},{n:OxO3a17[258],h:OxO3a17[259]},{n:OxO3a17[260],h:OxO3a17[261]},{n:OxO3a17[262],h:OxO3a17[263]},{n:OxO3a17[264],h:OxO3a17[265]},{n:OxO3a17[266],h:OxO3a17[267]},{n:OxO3a17[268],h:OxO3a17[269]},{n:OxO3a17[270],h:OxO3a17[271]},{n:OxO3a17[272],h:OxO3a17[273]}];
		
		</script>
	</head>
	<body>
		<div id="container">
			<div class="tab-pane-control tab-pane" id="tabPane1">
				<div class="tab-row">
					<h2 class="tab">
						<a tabindex="-1" href='colorpicker.aspx?<%=GetDialogQueryString%>'>
							<span style="white-space:nowrap;">
								[[WebPalette]]
							</span>
						</a>
					</h2>
					<h2 class="tab selected">
							<a tabindex="-1" href='colorpicker_basic.aspx?<%=GetDialogQueryString%>'>
								<span style="white-space:nowrap;">
									[[NamedColors]]
								</span>
							</a>
					</h2>
					<h2 class="tab">
							<a tabindex="-1" href='colorpicker_more.aspx?<%=GetDialogQueryString%>'>
								<span style="white-space:nowrap;">
									[[CustomColor]]
								</span>
							</a>
					</h2>
				</div>
				<div class="tab-page">			
					<table class="colortable" align="center">
						<tr>
							<td colspan="16" height="16"><p align="left">Basic:
								</p>
							</td>
						</tr>
						<tr>
							<script>
								var OxO892e=["length","\x3Ctd class=\x27colorcell\x27\x3E\x3Cdiv class=\x27colordiv\x27 style=\x27background-color:","\x27 title=\x27"," ","\x27 cname=\x27","\x27 cvalue=\x27","\x27\x3E\x3C/div\x3E\x3C/td\x3E",""];var arr=[];for(var i=0;i<colorlist[OxO892e[0]];i++){arr.push(OxO892e[1]);arr.push(colorlist[i].n);arr.push(OxO892e[2]);arr.push(colorlist[i].n);arr.push(OxO892e[3]);arr.push(colorlist[i].h);arr.push(OxO892e[4]);arr.push(colorlist[i].n);arr.push(OxO892e[5]);arr.push(colorlist[i].h);arr.push(OxO892e[6]);} ;document.write(arr.join(OxO892e[7]));
							</script>
						</tr>
						<tr>
							<td colspan="16" height="12"><p align="left"></p>
							</td>
						</tr>
						<tr>
							<td colspan="16"><p align="left">Additional:
								</p>
							</td>
						</tr>
						<script>
							var OxOd7a0=["length","\x3Ctr\x3E","\x3Ctd class=\x27colorcell\x27\x3E\x3Cdiv class=\x27colordiv\x27 style=\x27background-color:","\x27 title=\x27"," ","\x27 cname=\x27","\x27 cvalue=\x27","\x27\x3E\x3C/div\x3E\x3C/td\x3E","\x3C/tr\x3E",""];var arr=[];for(var i=0;i<colormore[OxOd7a0[0]];i++){if(i%16==0){arr.push(OxOd7a0[1]);} ;arr.push(OxOd7a0[2]);arr.push(colormore[i].n);arr.push(OxOd7a0[3]);arr.push(colormore[i].n);arr.push(OxOd7a0[4]);arr.push(colormore[i].h);arr.push(OxOd7a0[5]);arr.push(colormore[i].n);arr.push(OxOd7a0[6]);arr.push(colormore[i].h);arr.push(OxOd7a0[7]);if(i%16==15){arr.push(OxOd7a0[8]);} ;} ;if(colormore%16>0){arr.push(OxOd7a0[8]);} ;document.write(arr.join(OxOd7a0[9]));
						</script>
						<tr>
							<td colspan="16" height="8">
							</td>
						</tr>
						<tr>
							<td colspan="16" height="12">
								<input checked id="CheckboxColorNames" style="width: 16px; height: 20px" type="checkbox">
								<span style="width: 118px;">Use color names</span>
							</td>
						</tr>
						<tr>
							<td colspan="16" height="12">
							</td>
						</tr>
						<tr>
							<td colspan="16" valign="middle" height="24">
							<span style="height:24px;width:50px;vertical-align:middle;">Color : </span>&nbsp;
							<input type="text" id="divpreview" size="7" maxlength="7" style="width:180px;height:24px;border:#a0a0a0 1px solid; Padding:4;"/>
					
							</td>
						</tr>
				</table>
			</div>
		</div>
		<div id="container-bottom">
			<input type="button" id="buttonok" value="[[OK]]" class="formbutton" style="width:70px"	onclick="do_insert();" /> 
			&nbsp;&nbsp;&nbsp;&nbsp; 
			<input type="button" id="buttoncancel" value="[[Cancel]]" class="formbutton" style="width:70px"	onclick="do_Close();" />	
		</div>
	</div>
	</body>
</html>

