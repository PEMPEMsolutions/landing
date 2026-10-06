using System.Collections.Generic;
using System.Web.Mvc;
using LandingPage.Models;

namespace LandingPage.Controllers
{
    public class NosotrosController : Controller
    {
        public ActionResult Index()
        {
            var model = new NosotrosViewModel
            {
                Titulo = "Tecnolog&iacute;a pensada para avanzar.",
                Descripcion = "En PEMPEM'S Solutions desarrollamos soluciones digitales que ayudan a las empresas a mejorar sus procesos, organizar su informaci&oacute;n y aprovechar la tecnolog&iacute;a.",

                Socios = new List<SocioItem>
                {
                    new SocioItem
                    {
                        Numero = "SOCIO 01",
                        Nombre = "Diego Alejandro L&oacute;pez Amaya",
                        Cargo = "Desarrollo y Arquitectura de Software",
                        Descripcion = "Responsable del backend, bases de datos y l&oacute;gica del sistema. Dise&ntilde;a la arquitectura t&eacute;cnica y desarrolla los principales m&oacute;dulos de la soluci&oacute;n.",
                        Imagen = "~/Images/socio1.jpeg"
                    },

                    new SocioItem
                    {
                        Numero = "SOCIO 02",
                        Nombre = "Andrea Marielle Delgado Quintanilla",
                        Cargo = "Dise&ntilde;o e Interfaz de Usuario",
                        Descripcion = "Responsable del dise&ntilde;o visual y la experiencia de usuario. Desarrolla interfaces claras, accesibles y adaptadas a las necesidades del cliente.",
                        Imagen = "~/Images/socio2.jpeg"
                    },

                    new SocioItem
                    {
                        Numero = "SOCIO 03",
                        Nombre = "Ernesto Jos&eacute; Rivas Alvarado",
                        Cargo = "Aseguramiento de la Calidad y Documentaci&oacute;n",
                        Descripcion = "Encargado de las pruebas de software, control de errores y documentaci&oacute;n t&eacute;cnica para garantizar la calidad de las soluciones desarrolladas.",
                        Imagen = "~/Images/socio3.jpeg"
                    },

                    new SocioItem
                    {
                        Numero = "SOCIO 04",
                        Nombre = "Tania Nicole Flores Flores",
                        Cargo = "Gesti&oacute;n de Proyecto y Relaci&oacute;n con el Cliente",
                        Descripcion = "Coordina la planificaci&oacute;n del proyecto, gestiona el backlog, mantiene la comunicaci&oacute;n con el cliente y facilita la organizaci&oacute;n del equipo.",
                        Imagen = "~/Images/socio4.jpeg"
                    }
                },

                Procesos = new List<ProcesoItem>
                {
                    new ProcesoItem
                    {
                        Numero = "01",
                        Titulo = "Comprendemos",
                        Descripcion = "Analizamos las necesidades del cliente antes de comenzar el desarrollo."
                    },

                    new ProcesoItem
                    {
                        Numero = "02",
                        Titulo = "Dise&ntilde;amos",
                        Descripcion = "Convertimos las necesidades identificadas en propuestas y soluciones funcionales."
                    },

                    new ProcesoItem
                    {
                        Numero = "03",
                        Titulo = "Desarrollamos",
                        Descripcion = "Construimos soluciones digitales utilizando buenas pr&aacute;cticas de desarrollo."
                    },

                    new ProcesoItem
                    {
                        Numero = "04",
                        Titulo = "Mejoramos",
                        Descripcion = "Probamos, documentamos y mejoramos cada soluci&oacute;n para entregar un resultado &uacute;til."
                    }
                }
            };

            return View(model);
        }
    }
}