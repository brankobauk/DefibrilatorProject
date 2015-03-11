$(document).ready(function() {
    $("#AddProductProperty").click(function() {
        $.ajax({
            url: this.href,
            cache: false,
            success: function (html) { $("fieldset div.inputs").append(html); }
        });
        return false;
    });
});