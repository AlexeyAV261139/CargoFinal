namespace WinFormsApp2.DTO
{
    public class RouteDTO
    {
        public required string Destination { get; set; }

        public int? DistanceKm { get; set; }

        public decimal? Price { get; set; }

        public Guid DifficultyClassId { get; set; }
    }
}
