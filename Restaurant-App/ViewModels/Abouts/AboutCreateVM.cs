using System.ComponentModel.DataAnnotations;

namespace Restaurant_App.ViewModels.Abouts
{
    public class AboutCreateVM
    {
        [Required]
        public IFormFile Image { get; set; }

        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
