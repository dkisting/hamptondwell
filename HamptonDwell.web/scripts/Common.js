function checkEmail(inputvalue) {
    var pattern = /^([a-zA-Z0-9_.-])+@([a-zA-Z0-9_.-])+\.([a-zA-Z])+([a-zA-Z])+/;
    return pattern.test(inputvalue);
}
function checkPhone(inputvalue) {
    var regexObj = /^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$/;

    if (regexObj.test(inputvalue)) {
        var formattedPhoneNumber =
        inputvalue.replace(regexObj, "($1) $2-$3");
        return formattedPhoneNumber;
    } else {
        return "";
    }
}
function getQueryString(key, itemdefault) {
    if (itemdefault == null) itemdefault = "";
    key = key.replace(/[\[]/, "\\\[").replace(/[\]]/, "\\\]");
    var regex = new RegExp("[\\?&]" + key + "=([^&#]*)");
    var qs = regex.exec(window.location.href);
    if (qs == null)
        return itemdefault;
    else
        return qs[1];
}
$(document).ready(function () {
    $('input[name="TopNavSearch"]').click(function () {
        window.location.href = 'Search.aspx?search=' + $('input[name="search"]').val();
    });
});