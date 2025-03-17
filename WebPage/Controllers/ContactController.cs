using Microsoft.AspNetCore.Mvc;
using WebPage.Models;  // Importa el modelo ContactForm
using WebPage.Data;    // Importa el contexto de base de datos para interactuar con la BD

namespace WebPage.Controllers
{
    public class ContactController : Controller
    {
        [HttpPost]
        public JsonResult Submit(string Name, string Email, string Message)
        {
            if (string.IsNullOrWhiteSpace(Name) || string.IsNullOrWhiteSpace(Email) || string.IsNullOrWhiteSpace(Message))
            {
                return Json(new { message = "⚠️ Todos los campos son obligatorios." });
            }

            // Aquí podrías agregar lógica para guardar el mensaje en la BD

            return Json(new { message = "✅ Tu mensaje ha sido enviado con éxito." });
        }
    }
}