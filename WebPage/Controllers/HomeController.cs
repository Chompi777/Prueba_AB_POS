using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebPage.Models;

namespace WebPage.Controllers
{
    public class HomeController : Controller
    {
        // Acci�n que maneja la p�gina de inicio
        public IActionResult Index()
        {
            return View(); // Retorna la vista principal
        }
    }
}
