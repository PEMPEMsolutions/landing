using System.ComponentModel.DataAnnotations;

namespace LandingPage.Models
{
    public class ContactoViewModel
    {
        [Required(ErrorMessage = "El nombre es obligatorio.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El correo electr&oacute;nico es obligatorio.")]
        [EmailAddress(ErrorMessage = "Ingrese un correo electr&oacute;nico v&aacute;lido.")]
        public string Correo { get; set; }

        public string Telefono { get; set; }

        public string Asunto { get; set; }

        [Required(ErrorMessage = "El mensaje es obligatorio.")]
        public string Mensaje { get; set; }

        public bool Enviado { get; set; }
    }
}