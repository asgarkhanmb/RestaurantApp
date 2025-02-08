using Microsoft.EntityFrameworkCore;
using Restaurant_App.Data;
using Restaurant_App.Models;
using Restaurant_App.Services.Interfaces;

namespace Restaurant_App.Services
{
    public class InformationService : IInformationService
    {
        private readonly AppDbContext _context;
        public InformationService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Information>> GetAllAsync()
        {
            return await _context.Informations.ToListAsync();
        }

        public async Task<Information> GetByIdAsync(int id)
        {
            return await _context.Informations.Where(m => m.Id == id).FirstOrDefaultAsync();
        }
    }
}
