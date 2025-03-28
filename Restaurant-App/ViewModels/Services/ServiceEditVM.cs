namespace Restaurant_App.ViewModels.Services
{
    public class ServiceEditVM
    {
        public string Icon { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public IFormFile NewImage { get; set; }
    }
}
