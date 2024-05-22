using DB.Models;
using Microsoft.EntityFrameworkCore;

namespace DB
{
    public class CargoContext : DbContext
    {
        public DbSet<CargoEntity> Cargos { get; set; }

        public DbSet<CargoTypeEntity> CargoTypes { get; set; }

        public DbSet<Route> Routes { get; set; }

        public DbSet<DifficultyClass> DifficultyClasses { get; set; }

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

    public class Route : Entity
    {
        public required string Destination { get; set; }

        public int? DistanceKm { get; set; }

        public decimal? Price {  get; set; }

        public Guid DifficultyClassId {  get; set; }

        public DifficultyClass? DifficultyClass { get; set; }

        public override string ToString()
            => Destination;
    }

    public class DifficultyClass : Entity
    {
        public required string Name { get; set; }

        public List<Route> routes { get; set; } = [];

        public override string ToString()
            => Name;
    }

}
