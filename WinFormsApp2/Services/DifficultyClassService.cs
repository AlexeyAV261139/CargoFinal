using DB;
using DB.Models;
using Microsoft.EntityFrameworkCore;

namespace WinFormsApp2.Services
{
    public class DifficultyClassService
    {
        public async Task<List<DifficultyClass>> GetClasses()
        {
            using CargoContext context = new();
            return await context
                .DifficultyClasses
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
