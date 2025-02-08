using Restaurant_App.Models;

namespace Restaurant_App.Services.Interfaces
{
    public interface IAboutService
    {
        Task<List<About>> GetAllAsync();
        Task<About> GetByIdAsync(int id);
        Task<About> GetAboutAsync();
    }
}
