using System.ComponentModel.DataAnnotations;

namespace WebPage.Models
{
    public class ContactForm
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [StringLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "El correo electrónico es obligatorio.")]
        [EmailAddress(ErrorMessage = "Ingrese un correo válido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "El mensaje no puede estar vacío.")]
        [StringLength(500)]
        public string Message { get; set; }
    }
}
