namespace DB.Models
{
    public class CargoEntity : Entity
    {
        public string? Requirements { get; set; }

        public Guid CargoTypeId { get; set; }

        public CargoTypeEntity? CargoType { get; set; }

        public override string ToString()
            => CargoType?.ToString() ?? "";
    }

}
