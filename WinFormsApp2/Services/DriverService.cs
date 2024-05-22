using DB;
using DB.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace WinFormsApp2.Services
{
    public class DriverService
    {
        public async Task CreateDriver(DriverDTO dto)
        {
            using CargoContext context = new();
            Driver driver = new()
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Patronymic = dto.Patronymic,
                Birthdate = dto.Birthdate,
                Phone = dto.Phone,
                DifficultyClassId = dto.DifficultyClassId
            };
            await context.Drivers.AddAsync(driver);
            await context.SaveChangesAsync();
        }

        public async Task<List<Driver>> GetDrivers()
        {
            using CargoContext context = new();
            return await context
                .Drivers
                .AsNoTracking()
                .Include(x => x.DifficultyClass)
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<List<Driver>> GetSkillAndFreeDrivers(List<Guid> skills)
        {
            using CargoContext context = new();
            return await context
                .Drivers
                .AsNoTracking()
                .Include(x => x.DifficultyClass)
                .AsNoTracking()
                .Where(x => skills.Contains(x.DifficultyClassId))
                .Where(x => x.Trips
                    .All( x => x.End < DateTime.Now))
                .ToListAsync();
        }

        public async Task DeleteDriver(Guid id)
        {
            using CargoContext context = new();
            await context.Drivers
                .Where(x => x.Id == id)
                .ExecuteDeleteAsync();                
        }
    }

    public class DriverDTO
    {
        [MinLength(3)]
        public string FirstName { get; set; } = null!;

        [MinLength(3)]
        public string LastName { get; set; } = null!;

        public string? Patronymic { get; set; }

        public DateTime Birthdate { get; set; }

        [Phone]
        public string Phone { get; set; } = null!;

        public Guid DifficultyClassId { get; set; }

    }
}
