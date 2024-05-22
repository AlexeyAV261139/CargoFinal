using DB;
using DB.Models;
using Microsoft.EntityFrameworkCore;

namespace WinFormsApp2.Services
{
    public class CargoDTO
    {
        public required string Reequipments { get; init; }
        public required Guid TypeId { get; init; }
    }

    public class CargoService
    {
        public async Task CreateCargo(CargoDTO dto)
        {
            Cargo cargo = new()
            {
                Requirements = dto.Reequipments,
                CargoTypeId = dto.TypeId,
            };
            using CargoContext context = new();
            await context.Cargos.AddAsync(cargo);
            await context.SaveChangesAsync();
        }

        public async Task<List<Cargo>> GetCargos()
        {
            using CargoContext context = new();
            return await context.Cargos
                .AsNoTracking()
                .Include(x => x.CargoType)
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task DeleteCargo(Guid id)
        {
            using CargoContext context = new();
            await context.Cargos.Where(x => x.Id == id).ExecuteDeleteAsync();
        }
    }
}
