using DB.Models;

namespace DB
{
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

}
