$(document).ready(function () {
    $(".artist").mouseenter(function () {
        $(this).find("#link-div").removeClass("link-div-inactive");
        $(this).find("#link-div").addClass("link-div");

        $(this).find("#artist-boka").removeClass("artist-boka-inactive");
        $(this).find("#artist-boka").addClass("artist-boka");

        $(this).find("img").css("filter", "blur(8px) grayscale(100%)");
    });

    $(".artist").mouseleave(function () {
        $(this).find("#link-div").addClass("link-div-inactive");
        $(this).find("#link-div").removeClass("link-div");

        $(this).find("#artist-boka").addClass("artist-boka-inactive");
        $(this).find("#artist-boka").removeClass("artist-boka");

        $(this).find("img").css("filter", "none");
    });
});