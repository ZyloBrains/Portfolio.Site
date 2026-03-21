(function() {

    /* ====================
    Preloader
    ======================= */
	window.onload = function () {
		window.setTimeout(fadeout, 300);
	}

	function fadeout() {
		var preloader = document.querySelector('.preloader');
        if (preloader) {
            preloader.style.opacity = '0';
            preloader.style.display = 'none';
        }
	}

    // =========== sticky menu 
    window.onscroll = function () {
        var header_navbar = document.querySelector(".hero-section-wrapper-5 .header");
        if (header_navbar) {
            var sticky = header_navbar.offsetTop;
            if (window.pageYOffset > sticky) {
                header_navbar.classList.add("sticky");
            } else {
                header_navbar.classList.remove("sticky");
            }
        }

        // show or hide the back-top-top button
        var backToTo = document.querySelector(".scroll-top");
        if (backToTo) {
            if (document.body.scrollTop > 50 || document.documentElement.scrollTop > 50) {
                backToTo.style.display = "flex";
            } else {
                backToTo.style.display = "none";
            }
        }
    };

    // header-6  toggler-icon
    let navbarToggler6 = document.querySelector(".header-6 .navbar-toggler");
    var navbarCollapse6 = document.querySelector(".header-6 .navbar-collapse");

    if (navbarToggler6 && navbarCollapse6) {
        document.querySelectorAll(".header-6 .page-scroll").forEach(e =>
            e.addEventListener("click", () => {
                navbarToggler6.classList.remove("active");
                navbarCollapse6.classList.remove('show')
            })
        );
        navbarToggler6.addEventListener('click', function() {
            navbarToggler6.classList.toggle("active");
        });
    }

    // section menu active
	function onScroll(event) {
		var links = document.querySelectorAll('.page-scroll');
		var scrollPos = window.pageYOffset || document.documentElement.scrollTop || document.body.scrollTop;
		var found = false;
		links.forEach(function(currLink) {
			var val = currLink.getAttribute('href');
			if (!val || val.charAt(0) !== '#') return;
			var refElement = document.querySelector(val);
			if (!refElement) return;
			var scrollTopMinus = scrollPos + 73;
			if (refElement.offsetTop <= scrollTopMinus && (refElement.offsetTop + refElement.offsetHeight > scrollTopMinus)) {
				links.forEach(function(link) { link.classList.remove('active'); });
				currLink.classList.add('active');
				found = true;
			}
		});
		// If no section is found, remove all active classes
		if (!found) {
			links.forEach(function(link) { link.classList.remove('active'); });
		}
	}
    window.document.addEventListener('scroll', onScroll);

    // ===== pricing-style-4 slider
    if (typeof tns === 'function') {
        tns({
            container: '.pricing-active',
            autoplay: false,
            mouseDrag: true,
            gutter: 0,
            nav: false,
            controls: true,
            controlsText: [
                '<i class="lni lni-chevron-left prev"></i>',
                '<i class="lni lni-chevron-right prev"></i>',
            ],
            responsive: {
                0: {
                    items: 1,
                },
                768: {
                    items: 2,
                },
                992: {
                    items: 1.2,
                },
                1200: {
                    items: 2,
                }
            }
        });
    }

    // WOW active
    if (typeof WOW === 'function') {
        new WOW().init();
    }
})();