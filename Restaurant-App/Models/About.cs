using System.ComponentModel.DataAnnotations;

namespace Restaurant_App.Models
{
    public class About
    {
        [Required]
        [StringLength(200)]
        public string Title { get; set; }
        [Required]
        [StringLength(800)]
        public string Description { get; set; }
        public string Image { get; set; }
    }
}
