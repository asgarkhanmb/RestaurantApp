using Microsoft.AspNetCore.Mvc;

namespace Restaurant_App.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Service()
        {
            return View();
        }
    }
}
