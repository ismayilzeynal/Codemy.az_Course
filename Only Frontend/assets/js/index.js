// Navbar START
$("#parent-1").click(function(){
    $(this).toggleClass("rotate");
    $(".child-1").toggle();
});

$("#parent-2").click(function(){
    $(this).toggleClass("rotate");
    $(".child-2").toggle();
});

$(".fa-bars-staggered").click(function(){
    $(this).toggle();
    $(".fa-circle-xmark").toggle();
    $(".burger-menu").css("display","flex");
});

$(".fa-circle-xmark").click(function(){
    $(this).toggle();
    $(".fa-bars-staggered").toggle();
    $(".burger-menu").css("display","none");
});


// Navbar END