using System.ComponentModel.DataAnnotations;

namespace DB.Models
{
    public class Driver : Entity
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

        public DifficultyClass? DifficultyClass { get; set; }

        public List<Trip> Trips { get; set; } = [];

        public override string ToString()
            => $"{LastName} {FirstName} {Patronymic}";
    }
}
