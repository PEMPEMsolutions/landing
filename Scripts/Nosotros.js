document.addEventListener("DOMContentLoaded", function () {

    const elementos = document.querySelectorAll(
        ".nosotros-intro, " +
        ".hero-visual, " +
        ".section-heading, " +
        ".quienes-texto, " +
        ".equipo-heading, " +
        ".socio-card, " +
        ".trabajo-heading, " +
        ".proceso-item, " +
        ".nosotros-final"
    );

    const observador = new IntersectionObserver(
        function (entradas) {

            entradas.forEach(function (entrada) {

                if (entrada.isIntersecting) {

                    entrada.target.classList.add("visible");

                    observador.unobserve(entrada.target);
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

        observador.observe(elemento);
    });

    const links = document.querySelectorAll('a[href^="#"]');

    links.forEach(function (link) {

        link.addEventListener("click", function (event) {

            const targetId = this.getAttribute("href");

            if (!targetId || targetId === "#") {
                return;
            }

            const target = document.querySelector(targetId);

            if (target) {

                event.preventDefault();

                target.scrollIntoView({
                    behavior: "smooth",
                    block: "start"
                });
            }

        });

    });

});