using System.ComponentModel.DataAnnotations;

namespace LandingPage.Models
{
    public class CotizacionViewModel
    {
        [Required(ErrorMessage = "El nombre es obligatorio.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El correo es obligatorio.")]
        [EmailAddress(ErrorMessage = "Ingrese un correo v&aacute;lido.")]
        public string Correo { get; set; }

        public string Telefono { get; set; }

        public string Empresa { get; set; }

        [Required(ErrorMessage = "Seleccione un servicio.")]
        public string Servicio { get; set; }

        [Required(ErrorMessage = "Escriba una descripci&oacute;n del proyecto.")]
        public string Mensaje { get; set; }

        public bool Enviado { get; set; }
    }
}