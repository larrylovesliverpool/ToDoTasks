/* site.js */

$(function () {
    $(window).on("load resize", function () {
        $(".fill-screen").css("height", window.innerHeight);
    });

    //Bootstraps scroll spy
    $('body').scrollspy({
        target: '.navbar',
        offset: 160
    });

    // smooth scrolling easing
    $('nav a, .down-button a').bind('click', function () {
        $('html, body').stop().animate({
            scrollTop: $($(this).attr('href')).offset().top - 100
        }, 1500, 'easeInOutExpo');
        event.preventDefault();
    });

});

