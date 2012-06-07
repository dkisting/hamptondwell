var Type;
var Url;
var Data;
var ContentType;
var DataType;
var ProcessData;
var method;
//Generic function to call WCF  Service
function CallService() {
    $.ajax({
        type: Type, //GET or POST or PUT or DELETE verb
        url: Url, // Location of the service
        data: Data, //Data sent to server
        contentType: ContentType, // content type sent to server
        dataType: DataType, //Expected data format from server
        processdata: ProcessData, //True or False
        success: function (msg) {//On Successfull service call
            ServiceSucceeded(msg);
        },
        error: ServiceFailed// When Service call fails
    });
}

function ServiceFailed(result) {
    Type = null;
    Url = null;
    Data = null;
    ContentType = null;
    DataType = null;
    ProcessData = null;
}
function ServiceSucceeded(result) {
    if (DataType == "jsonp") {
        alert(result);
    }
}

function ServiceFailed(xhr) {
    alert(xhr.responseText);
    if (xhr.responseText) {
        var err = xhr.responseText;
        if (err)
            error(err);
        else
            error({ Message: "Unknown server error." })
    }
    return;
}
function GetJSONString(propertyNames, propertyValues) {
    var jsonString = '{';
    var i = 0;
    for (i = 0; i < propertyNames.length; i++) {
        jsonString += '"' + propertyNames[i] + '"';
        jsonString += ':';
        jsonString += '"' + propertyValues[i] + '"';
        if (i < propertyNames.length - 1) {
            jsonString += ',';
        }
    }
    jsonString += '}';
    return jsonString;
}
function onFail(result) {
    //alert("Error: " + result._message);
}
