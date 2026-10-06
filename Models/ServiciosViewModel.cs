using System.Collections.Generic;

namespace LandingPage.Models
{
    public class ServiciosViewModel
    {
        public string Titulo { get; set; }
        public string Descripcion { get; set; }

        public List<ServicioItem> Servicios { get; set; }

        public List<BeneficioItem> Beneficios { get; set; }
    }

    public class ServicioItem
    {
        public string Numero { get; set; }
        public string Icono { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string Imagen { get; set; }
        public List<string> Caracteristicas { get; set; }
    }

    public class BeneficioItem
    {
        public string Numero { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
    }
}