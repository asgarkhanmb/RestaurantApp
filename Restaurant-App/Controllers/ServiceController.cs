using Microsoft.AspNetCore.Mvc;
using Restaurant_App.Models;
using Restaurant_App.Services.Interfaces;
using Restaurant_App.ViewModels.Abouts;
using Restaurant_App.ViewModels.Informations;
using Restaurant_App.ViewModels.Services;

namespace Restaurant_App.Controllers
{
    public class ServiceController : Controller
    {
        private readonly IInformationService _informationService;

        public ServiceController(IInformationService informationService)
        {
            _informationService = informationService;
        }
        public async Task<IActionResult> Service()
        {
            var informResult = await _informationService.GetAllAsync();

            ServiceVM serviceVM = new ServiceVM
            {
                Informations = informResult?.Select(m => new Information
                {
                    Icon = m.Icon,
                    Title = m.Title,
                    Description = m.Description
                }).ToList() ?? new List<Information>()
            };

            return View(serviceVM);
        }
    }
}
