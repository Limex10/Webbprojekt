$(window).scroll(function () {
    if ($(window).scrollTop() < $(window).height()) {
        $(".navlogo").addClass("navlogotop");
        $(".navlogo").removeClass("navlogobottom");

        $("nav").addClass("navtop");
        $("nav").removeClass("navbottom");
    } else {
        $(".navlogo").addClass("navlogobottom");
        $(".navlogo").removeClass("navlogotop");

        $("nav").addClass("navbottom");
        $("nav").removeClass("navtop");
    }
});