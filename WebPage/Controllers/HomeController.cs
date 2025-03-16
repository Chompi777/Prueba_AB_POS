using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebPage.Models;

namespace WebPage.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
