$(document).ready(function () {
    $(document).on('click', '.thumbnail_product', function () {
        $('#main_product_image').attr('src',$(this).attr('src'));
    });

});