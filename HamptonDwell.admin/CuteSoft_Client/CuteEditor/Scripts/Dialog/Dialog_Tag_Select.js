var OxO9b1f=["inp_name","inp_access","inp_id","inp_index","inp_size","inp_Multiple","inp_Disabled","inp_item_text","inp_item_value","btnInsertItem","btnUpdateItem","btnDeleteItem","btnMoveUpItem","btnMoveDownItem","list_options","list_options2","inp_item_forecolor","inp_item_forecolor_Preview","inp_item_backcolor_Preview","text","value","color","style","backgroundColor","selectedIndex","options","Please select an item first","length","ondblclick","onclick","OPTION","document","id","cssText","Name","name","size","checked","disabled","multiple","tabIndex","","accessKey"];var inp_name=Window_GetElement(window,OxO9b1f[0],true);var inp_access=Window_GetElement(window,OxO9b1f[1],true);var inp_id=Window_GetElement(window,OxO9b1f[2],true);var inp_index=Window_GetElement(window,OxO9b1f[3],true);var inp_size=Window_GetElement(window,OxO9b1f[4],true);var inp_Multiple=Window_GetElement(window,OxO9b1f[5],true);var inp_Disabled=Window_GetElement(window,OxO9b1f[6],true);var inp_item_text=Window_GetElement(window,OxO9b1f[7],true);var inp_item_value=Window_GetElement(window,OxO9b1f[8],true);var btnInsertItem=Window_GetElement(window,OxO9b1f[9],true);var btnUpdateItem=Window_GetElement(window,OxO9b1f[10],true);var btnDeleteItem=Window_GetElement(window,OxO9b1f[11],true);var btnMoveUpItem=Window_GetElement(window,OxO9b1f[12],true);var btnMoveDownItem=Window_GetElement(window,OxO9b1f[13],true);var list_options=Window_GetElement(window,OxO9b1f[14],true);var list_options2=Window_GetElement(window,OxO9b1f[15],true);var inp_item_forecolor=Window_GetElement(window,OxO9b1f[16],true);var inp_item_forecolor=Window_GetElement(window,OxO9b1f[16],true);var inp_item_forecolor_Preview=Window_GetElement(window,OxO9b1f[17],true);var inp_item_backcolor_Preview=Window_GetElement(window,OxO9b1f[18],true);function SetOption(Ox19f){Ox19f[OxO9b1f[19]]=inp_item_text[OxO9b1f[20]];Ox19f[OxO9b1f[20]]=inp_item_value[OxO9b1f[20]];Ox19f[OxO9b1f[22]][OxO9b1f[21]]=inp_item_forecolor[OxO9b1f[20]];Ox19f[OxO9b1f[22]][OxO9b1f[23]]=inp_item_backcolor[OxO9b1f[20]];} ;function SetOption2(Ox19f){Ox19f[OxO9b1f[19]]=inp_item_value[OxO9b1f[20]];Ox19f[OxO9b1f[20]]=inp_item_text[OxO9b1f[20]];Ox19f[OxO9b1f[22]][OxO9b1f[21]]=inp_item_forecolor[OxO9b1f[20]];Ox19f[OxO9b1f[22]][OxO9b1f[23]]=inp_item_backcolor[OxO9b1f[20]];} ;function Select(Ox19f){var Ox59a=Ox19f[OxO9b1f[24]];list_options[OxO9b1f[24]]=Ox59a;list_options2[OxO9b1f[24]]=Ox59a;inp_item_text[OxO9b1f[20]]=list_options2[OxO9b1f[20]];inp_item_value[OxO9b1f[20]]=list_options[OxO9b1f[20]];} ;function Insert(){var Ox19f= new Option();SetOption(Ox19f);list_options[OxO9b1f[25]].add(Ox19f);var Ox59c= new Option();SetOption2(Ox59c);list_options2[OxO9b1f[25]].add(Ox59c);FireUIChanged();} ;function Update(){if(list_options[OxO9b1f[24]]==-1){alert(OxO9b1f[26]);return ;} ;var Ox19f=list_options.options(list_options.selectedIndex);SetOption(Ox19f);var Ox59c=list_options2.options(list_options2.selectedIndex);SetOption2(Ox59c);FireUIChanged();} ;function Move(Ox13b){var Ox59a=list_options[OxO9b1f[24]];if(Ox59a<0){return ;} ;var Ox59e=Ox59a-Ox13b;if(Ox59e<0){Ox59e=0;} ;if(Ox59e>(list_options[OxO9b1f[25]][OxO9b1f[27]]-1)){Ox59e=list_options[OxO9b1f[25]][OxO9b1f[27]]-1;} ;if(Ox59a==Ox59e){return ;} ;var Ox19f=list_options.options(list_options.selectedIndex);var Ox12=list_options2[OxO9b1f[20]];var Ox8=list_options[OxO9b1f[20]];Delete();inp_item_text[OxO9b1f[20]]=Ox12;inp_item_value[OxO9b1f[20]]=Ox8;var Ox19f= new Option();SetOption(Ox19f);list_options[OxO9b1f[25]].add(Ox19f,Ox59e);var Ox59c= new Option();SetOption2(Ox59c);list_options2[OxO9b1f[25]].add(Ox59c,Ox59e);list_options[OxO9b1f[24]]=Ox59e;list_options2[OxO9b1f[24]]=Ox59e;FireUIChanged();} ;function Delete(){if(list_options[OxO9b1f[24]]==-1||list_options[OxO9b1f[24]]==-1){alert(OxO9b1f[26]);return ;} ;var Ox59f=list_options[OxO9b1f[24]];var Ox19f=list_options.options(list_options.selectedIndex);Ox19f.removeNode(true);Ox19f=list_options2.options(list_options2.selectedIndex);Ox19f.removeNode(true);if(list_options[OxO9b1f[25]][OxO9b1f[27]]>Ox59f){list_options[OxO9b1f[24]]=Ox59f;} else {if(list_options[OxO9b1f[25]][OxO9b1f[27]]){list_options[OxO9b1f[24]]=list_options[OxO9b1f[25]][OxO9b1f[27]]-1;} ;} ;list_options.ondblclick();if(list_options2[OxO9b1f[25]][OxO9b1f[27]]>Ox59f){list_options2[OxO9b1f[24]]=Ox59f;} else {if(list_options2[OxO9b1f[25]][OxO9b1f[27]]){list_options2[OxO9b1f[24]]=list_options2[OxO9b1f[25]][OxO9b1f[27]]-1;} ;} ;FireUIChanged();} ;list_options[OxO9b1f[28]]=function list_options_ondblclick(){if(list_options[OxO9b1f[24]]==-1){return ;} ;var Ox19f=list_options.options(list_options.selectedIndex);inp_item_text[OxO9b1f[20]]=Ox19f[OxO9b1f[19]];inp_item_value[OxO9b1f[20]]=Ox19f[OxO9b1f[20]];inp_item_forecolor[OxO9b1f[20]]=inp_item_forecolor[OxO9b1f[22]][OxO9b1f[23]]=inp_item_forecolor_Preview[OxO9b1f[22]][OxO9b1f[23]]=Ox19f[OxO9b1f[22]][OxO9b1f[21]];inp_item_backcolor[OxO9b1f[20]]=inp_item_backcolor[OxO9b1f[22]][OxO9b1f[23]]=inp_item_backcolor_Preview[OxO9b1f[22]][OxO9b1f[23]]=Ox19f[OxO9b1f[22]][OxO9b1f[23]];} ;inp_item_forecolor[OxO9b1f[29]]=inp_item_forecolor_Preview[OxO9b1f[29]]=function inp_item_forecolor_onclick(){SelectColor(inp_item_forecolor,inp_item_forecolor_Preview);} ;inp_item_backcolor[OxO9b1f[29]]=inp_item_backcolor_Preview[OxO9b1f[29]]=function inp_item_backcolor_onclick(){SelectColor(inp_item_backcolor,inp_item_backcolor_Preview);} ;function CopySelect(Ox5a4,Ox5a5){Ox5a5[OxO9b1f[25]][OxO9b1f[27]]=0;for(var i=0;i<Ox5a4[OxO9b1f[25]][OxO9b1f[27]];i++){var Ox5a6=Ox5a4[OxO9b1f[25]][i];var Ox59c;if(Browser_IsWinIE()){Ox59c=Ox5a5[OxO9b1f[31]].createElement(OxO9b1f[30]);} else {Ox59c=document.createElement(OxO9b1f[30]);} ;if(Ox5a5[OxO9b1f[32]]!=OxO9b1f[15]){Ox59c[OxO9b1f[20]]=Ox5a6[OxO9b1f[20]];Ox59c[OxO9b1f[19]]=Ox5a6[OxO9b1f[19]];} else {Ox59c[OxO9b1f[20]]=Ox5a6[OxO9b1f[19]];Ox59c[OxO9b1f[19]]=Ox5a6[OxO9b1f[20]];} ;Ox59c[OxO9b1f[22]][OxO9b1f[33]]=Ox5a6[OxO9b1f[22]][OxO9b1f[33]];Ox5a5[OxO9b1f[25]].add(Ox59c);} ;Ox5a5[OxO9b1f[24]]=Ox5a4[OxO9b1f[24]];} ;UpdateState=function UpdateState_Select(){} ;SyncToView=function SyncToView_Select(){if(element[OxO9b1f[34]]){inp_name[OxO9b1f[20]]=element[OxO9b1f[34]];} ;if(element[OxO9b1f[35]]){inp_name[OxO9b1f[20]]=element[OxO9b1f[35]];} ;inp_id[OxO9b1f[20]]=element[OxO9b1f[32]];inp_size[OxO9b1f[20]]=element[OxO9b1f[36]];CopySelect(element,list_options);CopySelect(element,list_options2);inp_Disabled[OxO9b1f[37]]=element[OxO9b1f[38]];inp_Multiple[OxO9b1f[37]]=element[OxO9b1f[39]];if(element[OxO9b1f[40]]==0){inp_index[OxO9b1f[20]]=OxO9b1f[41];} else {inp_index[OxO9b1f[20]]=element[OxO9b1f[40]];} ;if(element[OxO9b1f[42]]){inp_access[OxO9b1f[20]]=element[OxO9b1f[42]];} ;} ;SyncTo=function SyncTo_Select(element){element[OxO9b1f[35]]=inp_name[OxO9b1f[20]];if(element[OxO9b1f[34]]){element[OxO9b1f[34]]=inp_name[OxO9b1f[20]];} else {if(element[OxO9b1f[35]]){element.removeAttribute(OxO9b1f[35],0);element[OxO9b1f[34]]=inp_name[OxO9b1f[20]];} else {element[OxO9b1f[34]]=inp_name[OxO9b1f[20]];} ;} ;element[OxO9b1f[32]]=inp_id[OxO9b1f[20]];element[OxO9b1f[36]]=inp_size[OxO9b1f[20]];element[OxO9b1f[38]]=inp_Disabled[OxO9b1f[37]];element[OxO9b1f[39]]=inp_Multiple[OxO9b1f[37]];element[OxO9b1f[42]]=inp_access[OxO9b1f[20]];element[OxO9b1f[40]]=inp_index[OxO9b1f[20]];if(element[OxO9b1f[40]]==OxO9b1f[41]){element.removeAttribute(OxO9b1f[40]);} ;if(element[OxO9b1f[42]]==OxO9b1f[41]){element.removeAttribute(OxO9b1f[42]);} ;CopySelect(list_options,element);} ;