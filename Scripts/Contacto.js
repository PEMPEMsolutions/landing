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


    const formulario =
        document.getElementById("contactoForm");

    if (formulario) {

        formulario.addEventListener(
            "submit",
            function () {

                const boton =
                    formulario.querySelector(
                        'button[type="submit"]'
                    );

                if (boton) {

                    boton.disabled = true;

                    boton.innerHTML =
                        "Enviando mensaje <span>&hellip;</span>";
                }

            }
        );
    }


    const campos =
        document.querySelectorAll(".form-control");

    campos.forEach(function (campo) {

        campo.addEventListener("focus", function () {

            this.parentElement.classList.add(
                "campo-activo"
            );

        });

        campo.addEventListener("blur", function () {

            this.parentElement.classList.remove(
                "campo-activo"
            );

        });

    });

});