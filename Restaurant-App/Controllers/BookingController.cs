using Microsoft.AspNetCore.Mvc;

namespace Restaurant_App.Controllers
{
    public class BookingController : Controller
    {
        public IActionResult Booking()
        {
            return View();
        }
    }
}
