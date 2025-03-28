using Microsoft.EntityFrameworkCore;
using Restaurant_App.Data;
using Restaurant_App.Models;
using Restaurant_App.Services.Interfaces;

namespace Restaurant_App.Services
{
    public class CategoryService :ICategoryService
    {
        private readonly AppDbContext _context;
        public CategoryService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Category>> GetAllAsync()
        {
            return await _context.Categories.ToListAsync();
        }

        public async Task<Category> GetByIdAsync(int id)
        {
            return await _context.Categories.Where(m => m.Id == id).FirstOrDefaultAsync();
        }

        public async Task<Category> GetAboutAsync()
        {
            return await _context.Categories.FirstAsync();
        }
    }
}
