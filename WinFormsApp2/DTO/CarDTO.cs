using System.ComponentModel.DataAnnotations;

namespace WinFormsApp2.DTO
{
    public class CarDTO
    {
        [MinLength(2)]
        public string Brand { get; set; } = null!;

        [MinLength(2)]
        public string Number { get; set; } = null!;

        [Range(0, int.MaxValue)]
        public int LoadCapacityKg { get; set; }
    }
}
