using System.ComponentModel.DataAnnotations;

namespace WinFormsApp2.Services
{
    public class ServiceManager
    {
        public CargoTypeService CargoTypeService { get; set; } = new();
        public CargoService CargoService { get; set; } = new();
        public RouteService RouteService { get; set; } = new();
        public DifficultyClassService DifficultyService { get; set; } = new();
        public DriverService DriverService { get; set; } = new();
        public CarService CarService { get; set; } = new();
    }

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
