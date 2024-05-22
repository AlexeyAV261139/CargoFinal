namespace DB.Models
{
    public class Cargo : Entity
    {
        public string? Requirements { get; set; }

        public Guid CargoTypeId { get; set; }

        public CargoTypeEntity? CargoType { get; set; }

        public List<Trip> Trips { get; set; } = [];

        public override string ToString()
            => CargoType?.ToString() ?? "";
    }

}
