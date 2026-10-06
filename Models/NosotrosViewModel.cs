using System.Collections.Generic;

namespace LandingPage.Models
{
    public class NosotrosViewModel
    {
        public string Titulo { get; set; }
        public string Descripcion { get; set; }

        public List<SocioItem> Socios { get; set; }
        public List<ProcesoItem> Procesos { get; set; }
    }

    public class SocioItem
    {
        public string Numero { get; set; }
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public string Descripcion { get; set; }
        public string Imagen { get; set; }
    }

    public class ProcesoItem
    {
        public string Numero { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
    }
}