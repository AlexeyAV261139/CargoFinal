using DB.Models;

namespace DB
{
    public class DifficultyClass : Entity
    {
        public required string Name { get; set; }

        public List<Route> Routes { get; set; } = [];

        public List<Driver> Drivers { get; set; } = [];

        public override string ToString()
            => Name;
    }

}
