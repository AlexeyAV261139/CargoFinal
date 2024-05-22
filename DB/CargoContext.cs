using DB.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace DB
{
    public class CargoContext : DbContext
    {
        public DbSet<Cargo> Cargos { get; set; }

        public DbSet<CargoTypeEntity> CargoTypes { get; set; }

        public DbSet<Route> Routes { get; set; }

        public DbSet<DifficultyClass> DifficultyClasses { get; set; }

        public DbSet<Driver> Drivers { get; set; }

        public DbSet<Car> Cars { get; set; }

        public DbSet<Trip> Trips { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=C:\\Users\\User\\Desktop\\programming\\My programs\\WinFormsApp2\\DB\\DB\\Cargos.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DifficultyClass>().HasData(
                [
                new DifficultyClass { Name = "1" },
                    new DifficultyClass { Name = "2" },
                    new DifficultyClass { Name = "3" },
                ]);
        }
    }

    public class Trip : Entity
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public Route? Route { get; set; }

        public Guid RouteId { get; set; }

        public Driver? Driver { get; set; }

        public Guid DriverId { get; set; }

        public Car? Car { get; set; }

        public Guid CarId { get; set; }

        public Cargo? Cargo { get; set; }

        public Guid CargoId { get; set; }
    }    
}
