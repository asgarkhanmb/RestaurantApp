using Restaurant_App.Models;

namespace Restaurant_App.ViewModels.Services
{
    public class ServiceVM
    {
        public int Id { get; set; }
        public string Icon { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public List<Information> Informations { get; set; } = new List<Information>();
    }
}
