$(function () {
    $("#calculate").click(sendForm);

    function sendForm() {

        if (validateForm()) {
            var data = {
                firstNumber : $("#firstNumber").val(),
                secondNumber : $("#secondNumber").val(),
                operation : $("#operation").val()
            };

            $.ajax({
                type: "POST",
                url: calculatorAPI,
                data: data,
                cache: false,
                success: function (data) {
                    data = JSON.parse(data);

                    $("#result").val(data.ResultValue);
                }
            });
        }
    }

    function validateForm() {
        $("#firstNumberError").html("");
        $("#secondNumberError").html("");
        
        if ($("#firstNumber").val().length == 0) {
            $("#firstNumberError").html("* Please enter a number"); 

            return false;
        }

        if ($("#secondNumber").val().length == 0) {
            $("#secondNumberError").html("* Please enter a number");

            return false;
        }

        if ($("#secondNumber").val() == "0" && $("#operation").val() == "Divide") {
            $("#secondNumberError").html("* Can not divide by zero");

            return false;
        }

        return true;
    }
});