using DB;
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

    public class RouteService
    {
        public async Task<List<Route>> GetRoutes()
        {
            using CargoContext context = new();
            return await context.Routes
                .AsNoTracking()
                .Include(x => x.DifficultyClass)
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task CreateRoute(RouteDTO dto)
        {
            Route route = new()
            {
                Destination = dto.Destination,
                DistanceKm = dto.DistanceKm,
                Price = dto.Price,
                DifficultyClassId = dto.DifficultyClassId,
            };
            using CargoContext context = new();
            await context.Routes.AddAsync(route);     
            await context.SaveChangesAsync();
        }

        public async Task DeleteRoute(Guid id)
        {
            using CargoContext context = new();
            await context.Routes
                .Where(x => x.Id == id)
                .ExecuteDeleteAsync();
        }

    }
    public class RouteDTO
    {
        public required string Destination {  get; set; }

        public int? DistanceKm { get; set; }

        public decimal? Price { get; set; } 

        public Guid DifficultyClassId { get; set; }
    }
}
