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


    const enlaceFigma =
        "https://www.figma.com/design/1XVLLoJpKlo3MqRfWl7LW5/FarmaCorps?node-id=0-1&t=VuNwa7KzqCgrCWnU-1";


    const botonPrincipal =
        document.getElementById("figmaButton");

    const botonInferior =
        document.getElementById("figmaButtonBottom");


    function abrirFigma() {

        window.open(
            enlaceFigma,
            "_blank",
            "noopener,noreferrer"
        );

    }


    if (botonPrincipal) {

        botonPrincipal.addEventListener(
            "click",
            abrirFigma
        );

    }


    if (botonInferior) {

        botonInferior.addEventListener(
            "click",
            abrirFigma
        );

    }

});