using Restaurant_App.Models;

namespace Restaurant_App.Services.Interfaces
{
    public interface ICategoryService
    {
        Task<List<Category>> GetAllAsync();
        Task<Category> GetByIdAsync(int id);
        Task<Category> GetAboutAsync();
    }
}
