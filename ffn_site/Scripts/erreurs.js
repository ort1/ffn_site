$(document).ready(function () {
    $(".erreur").load( function (e) {
        $(".erreur").fadeIn(300);
    });

    $(".erreur").mouseover(function (e) {
        $(".erreur").fadeOut(500);
    });
});