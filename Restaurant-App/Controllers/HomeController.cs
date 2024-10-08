using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Restaurant_App.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View(); // Returns the About view
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
