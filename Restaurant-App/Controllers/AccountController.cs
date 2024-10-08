using Microsoft.AspNetCore.Mvc;

namespace Restaurant_App.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult Forgotpassword()
        {
            return View();
        }
    }
}
