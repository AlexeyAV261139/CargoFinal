namespace DB.Models
{
    public class CargoTypeEntity : Entity
    {
        public required string Name { get; set; }

        public List<Cargo> Entities { get; set; } = [];

        public override string ToString()
            => Name;

    }

}
