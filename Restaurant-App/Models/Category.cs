namespace Restaurant_App.Models
{
    public class Category:BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public List<MenuItem> Items { get; set; } = new List<MenuItem>();
    }
}
