using System.Collections.Generic;

namespace LandingPage.Models
{
    public class ProyectosViewModel
    {
        public string Titulo { get; set; }
        public string Descripcion { get; set; }

        public List<ProyectoItem> Proyectos { get; set; }

        public List<CategoriaProyecto> Categorias { get; set; }
    }

    public class ProyectoItem
    {
        public string Numero { get; set; }
        public string Categoria { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string Imagen { get; set; }
        public string Tecnologias { get; set; }
    }

    public class CategoriaProyecto
    {
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
    }
}