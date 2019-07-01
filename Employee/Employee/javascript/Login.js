$(document).ready(function () {
    $("#txtUser").focus();

    if ($("#hdnErrorMsg").val() != "") {
        alert($("#hdnErrorMsg").val());
    }
});

function loginClick() {
    if ($("#txtUser").val() == "" && $("#txtPassword").val() == "") {
        alert("項目[UserName]は必ず入力してください. \r\n項目[Password]は必ず入力してください。");
        return false;
    }
    else if ($("#txtUser").val() == "") {
        alert("項目[UserName]は必ず入力してください。");
        return false;
    }
    else if ($("#txtPassword").val() == "") {
        alert("項目[Password]は必ず入力してください。");
        return false;
    }
    return true;
}