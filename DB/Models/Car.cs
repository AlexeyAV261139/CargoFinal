using System.ComponentModel.DataAnnotations;

namespace DB.Models
{
    public class Car : Entity
    {
        [MinLength(2)]
        public string Brand { get; set; } = null!;

        [MinLength(2)]
        public string Number { get; set; } = null!;

        [Range(0, int.MaxValue)]
        public int LoadCapacityKg { get; set; }

        public List<Trip> Trips { get; set; } = [];

        public override string ToString()
            => $"{Brand} N№{Number}";
    }
}
