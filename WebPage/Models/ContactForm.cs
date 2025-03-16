using System.ComponentModel.DataAnnotations;

namespace WebPage.Models
{
    // Modelo para almacenar la información del formulario de contacto
    public class ContactForm
    {
        [Key] // Define la clave primaria en la base de datos
        public int Id { get; set; }

        [Required] // Campo obligatorio
        public string Name { get; set; }

        [Required]
        [EmailAddress] // Valida que el campo tenga formato de correo electrónico
        public string Email { get; set; }

        [Required]
        public string Message { get; set; }
    }
}
