
$(function () {

    $('.photos').glisse({
        speed: 500,
        changeSpeed: 700,
        effect: 'fade',
        fullscreen: false
    });

    $('.tl').glisse({
        speed: 500,
        changeSpeed: 700,
        effect: 'fadeBig',
        fullscreen: false
    });
    $('#changefx').change(function () {
        var val = $(this).val();
        $('.tl').each(function () {
            $(this).data('glisse').changeEffect(val);
        });
    });
});
