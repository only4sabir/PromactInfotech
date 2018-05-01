
$(document).ready(function () {

    $(".active").removeClass(".active");
    var url = $(location).attr('href');
    //alert($(location).attr('href'));
    if (url.indexOf("/Department") != -1) {
        $("#aDep").addClass("active");
    }
    else if (url.indexOf("/Employee") != -1) {
        $("#aEmp").addClass("active");
    }

    $('#Contact').keypress(function (event) {
        if ($(this).length > 10) { return false;;}
        return isNumber(event, this)
    });
});
function isNumber(evt, element) {

    var charCode = (evt.which) ? evt.which : event.keyCode

    if (
        (charCode < 48 || charCode > 57))
        return false;

    return true;
}
function submitf() {
    var s = true;
    $("input").each(function () {
        var v = $(this);
        if (v.val() == "") {
            v.addClass("txtError"); s = false;
        } else {
            v.removeClass("txtError");
        }
    });
    $("select").each(function () {
        var v = $(this);
        if (v.text() == "") {
            v.addClass("txtError"); s = false;
        } else {
            v.removeClass("txtError");
        }
    });

    return s;
}