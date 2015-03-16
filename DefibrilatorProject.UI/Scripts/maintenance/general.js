$(document).ready(function() {
    $("#CompanyId").change(function() {
        ReloadPage();
    });
    $("#ProductId").change(function () {
        ReloadPage();
    });
});
function ReloadPage() {
    var productId = $("#ProductId option:selected").val();
    var companyId = $("#CompanyId option:selected").val();

    window.location = "/Maintenance?ProductId=" + productId + "&CompanyId=" + companyId;
}