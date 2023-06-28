// Navbar START
$(".parent").click(function () {
    $(this).toggleClass("rotate");
    let parentIdNumber = $(this).attr('id').split('-')[1];
    let childrenClass = ".child-" + parentIdNumber;
    $(childrenClass).toggle();
});


$(".burger-nav .fa-solid").click(function () {
    var $this = $(this);
    $this.toggle();
    var isBarsStaggered = $this.hasClass('fa-bars-staggered');
    $(".fa-xmark").toggle(isBarsStaggered);
    $(".fa-bars-staggered").toggle(!isBarsStaggered);
    $(".burger-menu").css("display", isBarsStaggered ? "flex" : "none");
    $("#carouselExampleIndicators").css("display", isBarsStaggered ? "none" : "block");
});
// Navbar END


// Subscribe START
document.querySelector('.submit-email').addEventListener('mousedown', (e) => {
    e.preventDefault();
    emailAdress = document.querySelector('.add-email').value;
    if (checkIfCorrectEmail(emailAdress))
        document.querySelector('.subscription').classList.add('done');
});
// Subscribe END



// Email Check START
function checkIfCorrectEmail(emailAdress) {
    var emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
    if (emailRegex.test(emailAdress))
        return true;
    else
        return false;
}
// Email Check END