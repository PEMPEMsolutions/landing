document.addEventListener("DOMContentLoaded", function () {

    const elementos = document.querySelectorAll(".reveal");

    if ("IntersectionObserver" in window) {

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
                threshold: 0.12
            }
        );

        elementos.forEach(function (elemento, indice) {

            elemento.style.transitionDelay =
                (indice * 0.06) + "s";

            observador.observe(elemento);
        });

    } else {

        elementos.forEach(function (elemento) {
            elemento.classList.add("visible");
        });
    }

    const tarjetas = document.querySelectorAll(".servicio-card");

    tarjetas.forEach(function (tarjeta) {

        tarjeta.addEventListener("mouseenter", function () {
            this.style.transform = "translateY(-7px)";
        });

        tarjeta.addEventListener("mouseleave", function () {
            this.style.transform = "";
        });

    });

});