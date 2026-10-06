using System.Collections.Generic;
using System.Web.Mvc;
using LandingPage.Models;

namespace LandingPage.Controllers
{
    public class ProyectosController : Controller
    {
        public ActionResult Index()
        {
            var model = new ProyectosViewModel
            {
                Titulo = "Proyectos que convierten ideas en soluciones.",
                Descripcion = "Conoce algunos de los proyectos y soluciones digitales desarrollados por PEMPEM'S Solutions.",

                Categorias = new List<CategoriaProyecto>
                {
                    new CategoriaProyecto
                    {
                        Nombre = "Todos",
                        Cantidad = 6
                    },

                    new CategoriaProyecto
                    {
                        Nombre = "Desarrollo web",
                        Cantidad = 2
                    },

                    new CategoriaProyecto
                    {
                        Nombre = "Sistemas",
                        Cantidad = 2
                    },

                    new CategoriaProyecto
                    {
                        Nombre = "Soluciones empresariales",
                        Cantidad = 2
                    }
                },

                Proyectos = new List<ProyectoItem>
                {
                    new ProyectoItem
                    {
                        Numero = "01",
                        Categoria = "DESARROLLO WEB",
                        Titulo = "Plataforma de servicios",
                        Descripcion = "Dise&ntilde;o y desarrollo de una plataforma web enfocada en presentar servicios de manera clara, moderna y accesible.",
                        Imagen = "https://images.unsplash.com/photo-1460925895917-afdab827c52f?auto=format&fit=crop&w=1200&q=80",
                        Tecnologias = "HTML · CSS · JavaScript · ASP.NET"
                    },

                    new ProyectoItem
                    {
                        Numero = "02",
                        Categoria = "SISTEMA ADMINISTRATIVO",
                        Titulo = "Sistema de gesti&oacute;n",
                        Descripcion = "Soluci&oacute;n para organizar informaci&oacute;n, administrar usuarios y facilitar diferentes procesos internos.",
                        Imagen = "https://images.unsplash.com/photo-1551288049-bebda4e38f71?auto=format&fit=crop&w=1200&q=80",
                        Tecnologias = "C# · ASP.NET MVC · SQL Server"
                    },

                    new ProyectoItem
                    {
                        Numero = "03",
                        Categoria = "DESARROLLO WEB",
                        Titulo = "Landing empresarial",
                        Descripcion = "Sitio web corporativo creado para comunicar la identidad, servicios y propuesta de valor de una empresa.",
                        Imagen = "https://images.unsplash.com/photo-1497366754035-f200968a6e72?auto=format&fit=crop&w=1200&q=80",
                        Tecnologias = "HTML · CSS · JavaScript"
                    },

                    new ProyectoItem
                    {
                        Numero = "04",
                        Categoria = "SISTEMA ADMINISTRATIVO",
                        Titulo = "Control de inventario",
                        Descripcion = "Sistema orientado al control de productos, existencias y movimientos de inventario.",
                        Imagen = "https://images.unsplash.com/photo-1556742049-0cfed4f6a45d?auto=format&fit=crop&w=1200&q=80",
                        Tecnologias = "C# · SQL Server · MVC"
                    },

                    new ProyectoItem
                    {
                        Numero = "05",
                        Categoria = "SOLUCIONES EMPRESARIALES",
                        Titulo = "Gesti&oacute;n de procesos",
                        Descripcion = "Propuesta digital para centralizar procesos y facilitar la administraci&oacute;n de las actividades de una organizaci&oacute;n.",
                        Imagen = "https://images.unsplash.com/photo-1553877522-43269d4ea984?auto=format&fit=crop&w=1200&q=80",
                        Tecnologias = "ASP.NET · SQL Server · JavaScript"
                    },

                    new ProyectoItem
                    {
                        Numero = "06",
                        Categoria = "SOLUCIONES EMPRESARIALES",
                        Titulo = "Plataforma personalizada",
                        Descripcion = "Soluci&oacute;n tecnol&oacute;gica desarrollada a partir de los requerimientos espec&iacute;ficos de un negocio.",
                        Imagen = "https://images.unsplash.com/photo-1551434678-e076c223a692?auto=format&fit=crop&w=1200&q=80",
                        Tecnologias = "C# · MVC · SQL Server"
                    }
                }
            };

            return View(model);
        }
    }
}