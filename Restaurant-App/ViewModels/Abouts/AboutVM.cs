using Restaurant_App.Models;

namespace Restaurant_App.ViewModels.Abouts
{
    public class AboutVM
    {
        public int? Id { get; set; }
        public string? Image { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public List<About> About { get; set; } = new List<About>();

    }
}
