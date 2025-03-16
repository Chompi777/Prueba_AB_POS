using Microsoft.AspNetCore.Mvc;
using WebPage.Models;  // Asegúrate de importar tus modelos
using WebPage.Data;    // Asegúrate de importar el espacio de nombres que contiene ApplicationDbContext

namespace WebPage.Controllers
{
    public class ContactController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ContactController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Submit(ContactForm model)
        {
            if (ModelState.IsValid)
            {
                _context.ContactForms.Add(model);
                await _context.SaveChangesAsync();
                return Json(new { success = true, message = "Mensaje enviado con éxito." });
            }
            return Json(new { success = false, message = "Error en el envío del formulario." });
        }
    }
}
