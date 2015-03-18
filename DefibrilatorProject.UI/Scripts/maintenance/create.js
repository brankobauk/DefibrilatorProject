$(document).ready(function () {
    $.ajax({
        url: "/company/CreateDropDown",
        cache: false,
        success: function (html) { $("#CompanyId").append(html); }
    });

    $("#CompanyId").change(function() {
        $.ajax({
            url: "/soldproduct/CreateDropDown/?CompanyId=" + $("#CompanyId option:selected").val(),
            cache: false,
            success: function (html) { $("#SoldProductIdDiv").html(html); }
        });
        $("#Maintenance_ProductPropertyId").html("");
    });

    $(document.body).on("change", "#Maintenance_SoldProductId", function () {
        $.ajax({
            url: "/product/CreateProductPropertyDropDown/?SoldProductId=" + $("#Maintenance_SoldProductId option:selected").val(),
            cache: false,
            success: function (html) { $("#ProductPropertyIdDiv").html(html); }
        });
    });

    $("#Maintenance_DateOfMainenance").addClass("date");
    $('#Maintenance_DateOfMainenance').prop('readOnly', true);
    $(".date").datepicker({
        dateFormat: 'dd.mm.yy',
        minDate: '1.1.2010'
    });
    jQuery.validator.addMethod(
            'date',
            function (value, element, params) {
                if (this.optional(element)) {
                    return true;
                };
                var result = false;
                try {
                    $.datepicker.parseDate('dd.mm.yy', value);
                    result = true;
                } catch (err) {
                    result = false;
                }
                return result;
            },
            ''
        );
});