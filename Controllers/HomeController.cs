using System.Collections.Generic;
using System.Web.Mvc;
using LandingPage.Models;

namespace LandingPage.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new HomeViewModel
            {
                Estadisticas = new List<StatItem>
                {
                    new StatItem
                    {
                        Valor = "10",
                        Texto = "Proyectos desarrollados"
                    },

                    new StatItem
                    {
                        Valor = "4",
                        Texto = "Socios especialistas"
                    },

                    new StatItem
                    {
                        Valor = "100%",
                        Texto = "Compromiso con cada cliente"
                    },

                    new StatItem
                    {
                        Valor = "∞",
                        Texto = "Posibilidades de crecimiento"
                    }
                },

                Servicios = new List<ServiceItem>
                {
                    new ServiceItem
                    {
                        Numero = "01",
                        Icono = "&lt;/&gt;",
                        Titulo = "Desarrollo web",
                        Descripcion = "Sitios web y plataformas modernas, responsivas, funcionales y adaptadas a cada proyecto."
                    },

                    new ServiceItem
                    {
                        Numero = "02",
                        Icono = "▦",
                        Titulo = "Sistemas administrativos",
                        Descripcion = "Herramientas para organizar informaci&oacute;n, automatizar procesos y facilitar la gesti&oacute;n empresarial."
                    },

                    new ServiceItem
                    {
                        Numero = "03",
                        Icono = "◇",
                        Titulo = "Soluciones para PYMES",
                        Descripcion = "Tecnolog&iacute;a accesible y personalizada para empresas que buscan mejorar sus procesos."
                    },

                    new ServiceItem
                    {
                        Numero = "04",
                        Icono = "+",
                        Titulo = "Soluciones digitales",
                        Descripcion = "Propuestas tecnol&oacute;gicas pensadas seg&uacute;n los objetivos y necesidades de cada negocio."
                    }
                },

                Proyectos = new List<ProjectItem>
                {
                    new ProjectItem
                    {
                        Numero = "PROYECTO 01",
                        Categoria = "DESARROLLO WEB",
                        Titulo = "Plataforma empresarial",
                        Descripcion = "Dise&ntilde;o y desarrollo de una soluci&oacute;n web adaptada a las necesidades del negocio."
                    },

                    new ProjectItem
                    {
                        Numero = "PROYECTO 02",
                        Categoria = "SISTEMA ADMINISTRATIVO",
                        Titulo = "Gesti&oacute;n empresarial",
                        Descripcion = "Sistema orientado a facilitar la administraci&oacute;n y organizaci&oacute;n de informaci&oacute;n."
                    },

                    new ProjectItem
                    {
                        Numero = "PROYECTO 03",
                        Categoria = "SOLUCI&Oacute;N DIGITAL",
                        Titulo = "Propuesta tecnol&oacute;gica",
                        Descripcion = "Una soluci&oacute;n creada para mejorar procesos y facilitar el trabajo de una empresa."
                    }
                }
            };

            return View(model);
        }
    }
}