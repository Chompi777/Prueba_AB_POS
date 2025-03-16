using Microsoft.AspNetCore.Mvc;
using WebPage.Models;  // Importa el modelo ContactForm
using WebPage.Data;    // Importa el contexto de base de datos para interactuar con la BD

namespace WebPage.Controllers
{
    public class ContactController : Controller
    {
        // Inyección de dependencias para acceder a la base de datos
        private readonly ApplicationDbContext _context;

        public ContactController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Método que maneja la recepción del formulario de contacto
        [HttpPost]
        public async Task<IActionResult> Submit(ContactForm model)
        {
            // Verifica si los datos enviados son válidos según el modelo
            if (ModelState.IsValid)
            {
                // Agrega el formulario recibido a la base de datos
                _context.ContactForms.Add(model);
                await _context.SaveChangesAsync();  // Guarda los cambios de forma asíncrona

                // Retorna una respuesta en formato JSON indicando éxito
                return Json(new { success = true, message = "Mensaje enviado con éxito." });
            }

            // Si los datos no son válidos, devuelve un mensaje de error
            return Json(new { success = false, message = "Error en el envío del formulario." });
        }
    }
}
