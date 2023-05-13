// Navbar START

$(".parent").click(function(){
    $(this).toggleClass("rotate");
    let parentIdNumber= $(this).attr('id').split('-')[1];
    let childrenClass = ".child-"+parentIdNumber;
    $(childrenClass).toggle();
});


$(".burger-nav .fa-solid").click(function(){
    var $this = $(this);
    $this.toggle();
    var isBarsStaggered = $this.hasClass('fa-bars-staggered');
    $(".fa-circle-xmark").toggle(isBarsStaggered);
    $(".fa-bars-staggered").toggle(!isBarsStaggered);
    $(".burger-menu").css("display", isBarsStaggered ? "flex" : "none");
});
