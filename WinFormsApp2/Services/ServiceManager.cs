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
        public TripService TripService { get; set; } = new();
    }
}
