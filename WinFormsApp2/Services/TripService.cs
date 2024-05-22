using DB;
using Microsoft.EntityFrameworkCore;
using WinFormsApp2.DTO;

namespace WinFormsApp2.Services
{
    public class TripService
    {
        public async Task<List<Trip>> GetTrips()
        {
            using CargoContext context = new CargoContext();
            return await context.Trips
                .AsNoTracking()                
                .Include(x => x.Route)
                .AsNoTracking()
                .Include(x => x.Car)
                .AsNoTracking()
                .Include(x => x.Driver)
                .AsNoTracking()
                .Include(x => x.Cargo)
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task CreateTrip(TripDTO dto)
        {
            Trip trip = new Trip()
            {
                Start = dto.Start,
                End = dto.End,
                RouteId = dto.RouteId,
                DriverId = dto.DriverId,
                CarId = dto.CarId,
                CargoId = dto.CargoId
            };
            using CargoContext context = new CargoContext();
            await context.Trips.AddAsync(trip);
            await context.SaveChangesAsync();
        }

        public async Task DeleteTrip(Guid id)
        {
            using CargoContext context = new CargoContext();
            await context.Trips
                .Where(x => x.Id == id)
                .ExecuteDeleteAsync();
        }
    }
}
