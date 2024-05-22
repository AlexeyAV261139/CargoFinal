using DB.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace DB
{
    public class CargoContext : DbContext
    {
        public DbSet<CargoEntity> Cargos { get; set; }

        public DbSet<CargoTypeEntity> CargoTypes { get; set; }

        public DbSet<Route> Routes { get; set; }

        public DbSet<DifficultyClass> DifficultyClasses { get; set; }

        public DbSet<Driver> Drivers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=C:\\Users\\User\\Desktop\\programming\\My programs\\WinFormsApp2\\DB\\DB\\Cargos.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DifficultyClass>().HasData(
                [
                new DifficultyClass { Name="1"},
                new DifficultyClass { Name="2"},
                new DifficultyClass { Name="3"},
                ]);
        }
    }

    public class Driver : Entity
    {
        [MinLength(3)]
        public string FirstName { get; set; } = null!;

        [MinLength(3)]
        public string LastName { get; set; } = null!;

        public string? Patronymic { get; set; }

        public DateTime Birthdate { get; set; }

        [Phone]
        public string Phone {  get; set; } = null!;

        public Guid DifficultyClassId { get; set; }

        public DifficultyClass? DifficultyClass { get; set; }
    }
}
