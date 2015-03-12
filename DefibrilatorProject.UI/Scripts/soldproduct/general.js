$(document).ready(function () {

    $("#SoldProduct_SoldDate").addClass("date");
    $('#SoldProduct_SoldDate').prop('readOnly', true);
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