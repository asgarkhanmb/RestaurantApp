using Microsoft.AspNetCore.Mvc;

namespace Restaurant_App.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Menu()
        {
            return View();
        }
    }
}
