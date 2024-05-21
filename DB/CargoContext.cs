using Microsoft.EntityFrameworkCore;

namespace DB
{
    public class CargoContext : DbContext
    {
        public DbSet<CargoEntity> Cargos { get; set; }

        public DbSet<CargoTypeEntity> CargoTypes { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=C:\\Users\\User\\Desktop\\programming\\My programs\\WinFormsApp2\\DB\\DB\\Cargos.db");
        }
    }

    public class CargoTypeEntity : Entity
    {
        public required string Name { get; set; }

        public List<CargoEntity> Entities { get; set; } = [];

        public override string ToString()
            => Name;

    }

    public class CargoEntity : Entity
    {
        public string? Requirements {  get; set; }

        public Guid CargoTypeId { get; set; }

        public CargoTypeEntity? CargoType {  get; set; }

        public override string ToString()
            => CargoType?.ToString() ?? "";
    }

}
