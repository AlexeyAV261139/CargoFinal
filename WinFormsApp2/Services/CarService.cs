using DB;
using Microsoft.EntityFrameworkCore;

namespace WinFormsApp2.Services
{
    public class CarService
    {
        public async Task CreateCar(CarDTO dto)
        {
            using CargoContext context = new CargoContext();
            Car car = new()
            {
                Brand = dto.Brand,
                Number = dto.Number,
                LoadCapacityKg = dto.LoadCapacityKg,
            };
            await context.Cars.AddAsync(car);
            await context.SaveChangesAsync();
        }

        public async Task<List<Car>> GetCars()
        {
            using CargoContext context = new CargoContext();
            return await context.Cars
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task DeleteCar(Guid id)
        {
            using CargoContext context = new CargoContext();
            await context.Cars
                .Where(x => x.Id == id)
                .ExecuteDeleteAsync();
        }
    }
}
