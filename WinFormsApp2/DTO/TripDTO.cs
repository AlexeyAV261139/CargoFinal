using System.ComponentModel.DataAnnotations;

namespace WinFormsApp2.DTO
{
    public class TripDTO
    {
        public DateTime Start { get; set; }

        [Required]
        public DateTime End { get; set; }

        [Required]
        public Guid RouteId { get; set; }

        [Required]
        public Guid DriverId { get; set; }

        [Required]
        public Guid CarId { get; set; }

        [Required]
        public Guid CargoId { get; set; }
    }
}
