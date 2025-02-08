using Microsoft.AspNetCore.Mvc;
using Restaurant_App.Models;
using Restaurant_App.Services.Interfaces;
using Restaurant_App.ViewModels;
using Restaurant_App.ViewModels.Abouts;
using Restaurant_App.ViewModels.Informations;

namespace Restaurant_App.Controllers
{
    public class AboutController : Controller
    {
        private readonly IAboutService _aboutService;

        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public async Task<IActionResult> About()
        {
          var aboutResult = await _aboutService.GetAllAsync();

           
          AboutVM aboutVM = new AboutVM
           {
               About = aboutResult?.Select(m => new About
               {
                   Image = m.Image,
                   Title = m.Title,
                   Description = m.Description
               }).ToList() ?? new List<About>()
           };
            return View(aboutVM);
        }
    }

}
