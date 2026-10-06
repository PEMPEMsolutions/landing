using System.Collections.Generic;
using System.Web.Mvc;
using LandingPage.Models;

namespace LandingPage.Controllers
{
    public class ServiciosController : Controller
    {
        public ActionResult Index()
        {
            var model = new ServiciosViewModel
            {
                Titulo = "Soluciones digitales para cada necesidad.",
                Descripcion = "Creamos herramientas tecnol&oacute;gicas que ayudan a las empresas a mejorar sus procesos, organizar su informaci&oacute;n y ofrecer mejores experiencias.",

                Servicios = new List<ServicioItem>
                {
                    new ServicioItem
                    {
                        Numero = "01",
                        Icono = "&lt;/&gt;",
                        Titulo = "Desarrollo web",
                        Descripcion = "Dise&ntilde;amos y desarrollamos sitios web modernos, responsivos y adaptados a las necesidades de cada proyecto.",
                        Imagen = "https://images.unsplash.com/photo-1498050108023-c5249f4df085?auto=format&fit=crop&w=1000&q=80",
                        Caracteristicas = new List<string>
                        {
                            "Dise&ntilde;o responsivo",
                            "Interfaces personalizadas",
                            "Desarrollo frontend y backend",
                            "Optimizaci&oacute;n para diferentes dispositivos"
                        }
                    },

                    new ServicioItem
                    {
                        Numero = "02",
                        Icono = "▦",
                        Titulo = "Sistemas administrativos",
                        Descripcion = "Desarrollamos sistemas que permiten centralizar informaci&oacute;n y facilitar la gesti&oacute;n de las operaciones de una empresa.",
                        Imagen = "https://images.unsplash.com/photo-1551434678-e076c223a692?auto=format&fit=crop&w=1000&q=80",
                        Caracteristicas = new List<string>
                        {
                            "Gesti&oacute;n de usuarios",
                            "Control de procesos",
                            "M&oacute;dulos administrativos",
                            "Informaci&oacute;n centralizada"
                        }
                    },

                    new ServicioItem
                    {
                        Numero = "03",
                        Icono = "◈",
                        Titulo = "Bases de datos",
                        Descripcion = "Dise&ntilde;amos estructuras de datos organizadas para almacenar, consultar y administrar la informaci&oacute;n de forma eficiente.",
                        Imagen = "https://images.unsplash.com/photo-1558494949-ef010cbdcc31?auto=format&fit=crop&w=1000&q=80",
                        Caracteristicas = new List<string>
                        {
                            "Dise&ntilde;o de bases de datos",
                            "Relaciones entre entidades",
                            "Consultas SQL",
                            "Integraci&oacute;n con aplicaciones"
                        }
                    },

                    new ServicioItem
                    {
                        Numero = "04",
                        Icono = "↗",
                        Titulo = "Soluciones empresariales",
                        Descripcion = "Creamos soluciones tecnol&oacute;gicas personalizadas para resolver problemas espec&iacute;ficos y mejorar el funcionamiento de los negocios.",
                        Imagen = "https://images.unsplash.com/photo-1552664730-d307ca884978?auto=format&fit=crop&w=1000&q=80",
                        Caracteristicas = new List<string>
                        {
                            "An&aacute;lisis de necesidades",
                            "Automatizaci&oacute;n de procesos",
                            "Soluciones personalizadas",
                            "Escalabilidad"
                        }
                    },

                    new ServicioItem
                    {
                        Numero = "05",
                        Icono = "◎",
                        Titulo = "Experiencia de usuario",
                        Descripcion = "Creamos interfaces claras y funcionales para que las personas puedan utilizar las plataformas de manera sencilla.",
                        Imagen = "https://images.unsplash.com/photo-1559028012-481c04fa702d?auto=format&fit=crop&w=1000&q=80",
                        Caracteristicas = new List<string>
                        {
                            "Interfaces intuitivas",
                            "Dise&ntilde;o centrado en el usuario",
                            "Arquitectura de informaci&oacute;n",
                            "Experiencia multiplataforma"
                        }
                    },

                    new ServicioItem
                    {
                        Numero = "06",
                        Icono = "+",
                        Titulo = "Consultor&iacute;a tecnol&oacute;gica",
                        Descripcion = "Analizamos las necesidades de cada organizaci&oacute;n para proponer alternativas tecnol&oacute;gicas adecuadas a sus objetivos.",
                        Imagen = "https://images.unsplash.com/photo-1556761175-b413da4baf72?auto=format&fit=crop&w=1000&q=80",
                        Caracteristicas = new List<string>
                        {
                            "An&aacute;lisis de procesos",
                            "Identificaci&oacute;n de oportunidades",
                            "Propuestas tecnol&oacute;gicas",
                            "Acompa&ntilde;amiento"
                        }
                    }
                },

                Beneficios = new List<BeneficioItem>
                {
                    new BeneficioItem
                    {
                        Numero = "01",
                        Titulo = "Soluciones personalizadas",
                        Descripcion = "Cada proyecto se desarrolla considerando las necesidades y objetivos espec&iacute;ficos del cliente."
                    },

                    new BeneficioItem
                    {
                        Numero = "02",
                        Titulo = "Tecnolog&iacute;a funcional",
                        Descripcion = "Buscamos que cada herramienta desarrollada tenga una utilidad real dentro de la organizaci&oacute;n."
                    },

                    new BeneficioItem
                    {
                        Numero = "03",
                        Titulo = "Enfoque en el usuario",
                        Descripcion = "Priorizamos interfaces claras y experiencias sencillas para facilitar el uso de las soluciones."
                    }
                }
            };

            return View(model);
        }
    }
}