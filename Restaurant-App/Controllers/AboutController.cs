using Microsoft.AspNetCore.Mvc;

namespace Restaurant_App.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult About()
        {
            return View();
        }
    }
}
