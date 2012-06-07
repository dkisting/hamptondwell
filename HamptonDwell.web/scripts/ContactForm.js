$(document).ready(function () {

    $(function () {

        $("input[id=CommentFormSubmit]").click(function () {



            this.disabled = true;
            var name = $("#name").val();
            var email = $("#email").val();
            var comments = $("#comments").val();

            if (checkEmail(email) == false) {
                alert("Please enter a valid email");
                this.disabled = false;
                return false;
            }
            var jsonData = GetJSONString(["Name", "Email", "Message"], [name, email, comments]);

            var proxy = new ebsWebServices.MessageQueueWebService();
            proxy.set_enableJsonp(true);
            proxy.CreateEmailQueue(jsonData, onUpdateSuccess, onFail, null);

            if ($("#SuccessMessage").size() > 0) {
                $("#SuccessMessage")[0].style.display = 'inline';
            }
            return false;
        });
        $("input[id=QuoteFormSubmit]").click(function () {

            this.disabled = true;
            var name = $("#name").val();
            var email = $("#email").val();
            var phoneNumber = checkPhone($("#phone").val());
            var address = $("#address").val();
            var bestDays = $("#bestDays").val();
            var commentsText = $("#comments").val();

            var comments = "Address: " + address + "<BR />";
            comments += "Phone Number: " + phoneNumber + "<BR />";
            comments += "Best Days to Contact: " + bestDays + "<BR />";
            comments += "Notes: " + commentsText;


            if (checkEmail(email) == false) {
                alert("Please enter a valid email");
                this.disabled = false;
                return false;
            }
            if (phoneNumber == "") {
                alert("Please enter a valid phone number");
                this.disabled = false;
                return false;
            }
            
            
            var jsonData = GetJSONString(["Name", "Email", "Message"], [name, email, comments]);

            var proxy = new ebsWebServices.MessageQueueWebService();
            proxy.set_enableJsonp(true);
            proxy.CreateEmailQueue(jsonData, onUpdateSuccess, onFail, null);

           
            return false;
        });
    });
});

function onUpdateSuccess(result) {
    if (result == 1) {
        if ($("#SuccessMessage").size() > 0) {
            $("#SuccessMessage")[0].style.display = 'inline';
        }
    }
}
