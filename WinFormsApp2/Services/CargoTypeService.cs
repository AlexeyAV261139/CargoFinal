using DB;
using Microsoft.EntityFrameworkCore;

namespace WinFormsApp2.Services
{
    public class CargoTypeService
    {
        public async void CreateCargoType(string name)
        {
            CargoTypeEntity type = new()
            {
                Name = name
            };
            using CargoContext context = new();
            await context.CargoTypes.AddAsync(type);
            await context.SaveChangesAsync();
        }

        public async Task<List<CargoTypeEntity>> GetCargoTypes()
        {
            using CargoContext context = new();
            return await context.CargoTypes
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task DeleteCargoType(Guid id)
        {
            using CargoContext context = new();
            await context.CargoTypes.Where(x => x.Id == id).ExecuteDeleteAsync();
        }
    }
}
