$(document).ready(function () {

    $(function () {

        var searchString = getQueryString("search", "");

        if (searchString.length > 2) {
            var jsonData = GetJSONString(["SearchCriteria"], [searchString]);

            var proxy = new ebsWebServices.MessageQueueWebService();
            proxy.set_enableJsonp(true);
            proxy.GetSearchResults(jsonData, onGetSearchResultsSuccess, onGetSearchResultsFailed, null);


        }
    });

});


function onGetSearchResultsSuccess(result) {
    var objResult = eval("(SearchResultList = " + result + ")");

    $("#SearchResultSelection tr:not(tr:has(th))").remove();
    $("#SearchResultSelection")[0].style.display = 'block';
    $("#searchresult-selection-row").tmpl(objResult).appendTo("#SearchResultSelection");



}
function onGetSearchResultsFailed(result) {
    alert("Method Failed: " + result.get_message());
}
