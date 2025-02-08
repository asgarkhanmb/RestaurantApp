using Restaurant_App.Models;
using Restaurant_App.ViewModels.Abouts;
using Restaurant_App.ViewModels.Informations;

namespace Restaurant_App.ViewModels
{
    public class HomeVM
    {
        public Slider Sliders { get; set; }
        public List<InformationVM> Informations { get; set; } = new();
        public List<AboutVM> Abouts { get; set; }
    }
}
