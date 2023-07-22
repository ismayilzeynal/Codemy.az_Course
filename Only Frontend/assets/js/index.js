$(document).ready(function () {




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
        $("#login").css("display", isBarsStaggered ? "none" : "flex");

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





    // Login START
    (function ($) {
        "use strict";
        $('.input100').each(function () {
            $(this).on('blur', function () {
                if ($(this).val().trim() != "") {
                    $(this).addClass('has-val');
                }
                else {
                    $(this).removeClass('has-val');
                }
            })
        })
        var input = $('.validate-input .input100');
        $('.validate-form').on('submit', function () {
            var check = true;

            for (var i = 0; i < input.length; i++) {
                if (validate(input[i]) == false) {
                    showValidate(input[i]);
                    check = false;
                }
            }
            return check;
        });

        $('.validate-form .input100').each(function () {
            $(this).focus(function () {
                hideValidate(this);
            });
        });

        function validate(input) {
            if ($(input).attr('type') == 'email' || $(input).attr('name') == 'email') {
                if ($(input).val().trim().match(/^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{1,5}|[0-9]{1,3})(\]?)$/) == null) {
                    return false;
                }
            }
            else {
                if ($(input).val().trim() == '') {
                    return false;
                }
            }
        }

        function showValidate(input) {
            var thisAlert = $(input).parent();

            $(thisAlert).addClass('alert-validate');
        }

        function hideValidate(input) {
            var thisAlert = $(input).parent();

            $(thisAlert).removeClass('alert-validate');
        }


        var showPass = 0;
        $('.btn-show-pass').on('click', function () {
            if (showPass == 0) {
                $(this).next('input').attr('type', 'text');
                $(this).find('i').removeClass('zmdi-eye');
                $(this).find('i').addClass('zmdi-eye-off');
                showPass = 1;
            }
            else {
                $(this).next('input').attr('type', 'password');
                $(this).find('i').addClass('zmdi-eye');
                $(this).find('i').removeClass('zmdi-eye-off');
                showPass = 0;
            }
        });
    })(jQuery);
    // Login END


    // Compeitions START
    $('.card .row .col-md-4 img').click(function (e) {
        e.preventDefault();
        var link = $(this).parent().next().find('a').attr('href');
        window.open(link, '_blank');
    });
    // Compeitions END





});



// Profil page sections width
const iconSideWidth = $('.icon-side').width();
let maxWidthP = 0;
$('#profil .container-2 .profil-down .profil-about .info-sec p').each(function () {
    let newWidth = $(this).width();
    if (newWidth > maxWidthP) {
        maxWidthP = newWidth;
    }
});
$('#profil .container-2 .profil-down .profil-about').width(iconSideWidth + maxWidthP + 50);




// Document Scan START
function onScanSuccess(qrCodeMessage) {
    $('#hiddenDocumentId').val(qrCodeMessage);
    $('#id-src-input').val(qrCodeMessage);
    // redirect to link + /qrCodeMessage
}
function onScanError(errorMessage) {}

var html5QrCodeScanner = new Html5QrcodeScanner("reader", {
    fps: 10,
    qrbox: 250
});
html5QrCodeScanner.render(onScanSuccess, onScanError);
// Document Scan END









