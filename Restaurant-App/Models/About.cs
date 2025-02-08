using System.ComponentModel.DataAnnotations;

namespace Restaurant_App.Models
{
    public class About :BaseEntity
    {
        [Required]
        [StringLength(200)]
        public string Title { get; set; }
        [Required]
        [StringLength(800)]
        public string Description { get; set; }
        public string Image { get; set; }

        public static implicit operator List<object>(About v)
        {
            throw new NotImplementedException();
        }

        public static implicit operator About(List<About> v)
        {
            throw new NotImplementedException();
        }
    }
}
