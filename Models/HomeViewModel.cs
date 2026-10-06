using System.Collections.Generic;

namespace LandingPage.Models
{
    public class HomeViewModel
    {
        public List<StatItem> Estadisticas { get; set; }
        public List<ServiceItem> Servicios { get; set; }
        public List<ProjectItem> Proyectos { get; set; }
    }

    public class StatItem
    {
        public string Valor { get; set; }
        public string Texto { get; set; }
    }

    public class ServiceItem
    {
        public string Numero { get; set; }
        public string Icono { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
    }

    public class ProjectItem
    {
        public string Numero { get; set; }
        public string Categoria { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
    }
}