using Microsoft.EntityFrameworkCore;
using Restaurant_App.Data;
using Restaurant_App.Models;
using Restaurant_App.Services.Interfaces;

namespace Restaurant_App.Services
{
    public class AboutService :IAboutService
    {
        private readonly AppDbContext _context;
        public AboutService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<About> GetAboutAsync()
        {
            return await _context.Abouts.FirstOrDefaultAsync();
        }

        public async Task<About> GetByIdAsync(int id)
        {
            return await _context.Abouts.Where(m => m.Id == id).FirstOrDefaultAsync();
        }

        public async Task<List<About>> GetAllAsync()
        {
            return await _context.Abouts.ToListAsync();
        }
    }
}
