using Microsoft.AspNetCore.Mvc;

namespace Restaurant_App.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Contact()
        {
            return View();
        }
    }
}
