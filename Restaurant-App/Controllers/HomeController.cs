using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Restaurant_App.Services.Interfaces;
using Restaurant_App.ViewModels.Informations;
using Restaurant_App.ViewModels;
using System.Diagnostics;
using Restaurant_App.ViewModels.Abouts;

namespace Restaurant_App.Controllers
{
    public class HomeController : Controller
    {
        private readonly IInformationService _informationService;
        private readonly IAboutService _aboutService;

        public HomeController(IInformationService informationService, IAboutService aboutService)
        {
            _informationService = informationService;
            _aboutService = aboutService;
        }

        public async Task<IActionResult> Index()
        {
            var informationResult = await _informationService.GetAllAsync();
            var aboutResult = await _aboutService.GetAllAsync();

            HomeVM model = new()
            {
                Informations = informationResult?.Select(m => new InformationVM
                {
                    Icon = m.Icon,
                    Title = m.Title,
                    Description = m.Description,
                }).ToList() ?? new List<InformationVM>(), // Ensure no null references

                Abouts = aboutResult?.Select(m => new AboutVM
                {
                    Image = m.Image,
                    Title = m.Title,
                    Description = m.Description

                }).ToList() ?? new List<AboutVM>()

                // Assign the About result directly
            };

            return View(model);
        }
    }

}
