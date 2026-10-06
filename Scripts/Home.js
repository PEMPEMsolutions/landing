document.addEventListener("DOMContentLoaded", function () {

    /* =====================================================
       ANIMACIONES AL HACER SCROLL
       ===================================================== */

    const elementos = document.querySelectorAll(".reveal");

    if ("IntersectionObserver" in window) {

        const observer = new IntersectionObserver(

            function (entries) {

                entries.forEach(function (entry) {

                    if (entry.isIntersecting) {

                        entry.target.classList.add("visible");

                        observer.unobserve(entry.target);

                    }

                });

            },

            {
                threshold: 0.15
            }

        );


        elementos.forEach(function (elemento, indice) {

            elemento.style.transitionDelay =
                (indice * 0.05) + "s";

            observer.observe(elemento);

        });

    }
    else {

        elementos.forEach(function (elemento) {

            elemento.classList.add("visible");

        });

    }


    /* =====================================================
       EFECTO HOVER DE LAS TARJETAS
       ===================================================== */

    const cards = document.querySelectorAll(
        ".service-card, .portfolio-card"
    );


    cards.forEach(function (card) {

        card.addEventListener("mouseenter", function () {

            this.style.transform = "translateY(-5px)";

        });


        card.addEventListener("mouseleave", function () {

            this.style.transform = "";

        });

    });


    /* =====================================================
       ANIMACI&Oacute;N DE ESTAD&Iacute;STICAS
       ===================================================== */

    const stats = document.querySelectorAll(".stat strong");


    stats.forEach(function (stat) {

        const value = stat.textContent.trim();

        if (!/^\d+$/.test(value)) {
            return;
        }

        const finalValue = parseInt(value, 10);

        let currentValue = 0;

        const duration = 900;

        const startTime = performance.now();


        function animate(currentTime) {

            const elapsed = currentTime - startTime;

            const progress =
                Math.min(elapsed / duration, 1);

            currentValue =
                Math.floor(finalValue * progress);

            stat.textContent = currentValue;


            if (progress < 1) {

                requestAnimationFrame(animate);

            }
            else {

                stat.textContent = finalValue;

            }

        }


        requestAnimationFrame(animate);

    });

});