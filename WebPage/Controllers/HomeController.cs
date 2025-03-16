using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebPage.Models;

namespace WebPage.Controllers
{
    public class HomeController : Controller
    {
        // Acción que maneja la página de inicio
        public IActionResult Index()
        {
            return View(); // Retorna la vista principal
        }
    }
}
