using WinFormsApp2.Services;

namespace WinFormsApp2
{
    public class ServiceManager
    {
        public CargoTypeService CargoTypeService { get; set; } = new CargoTypeService();
        public CargoService CargoService { get; set; } = new();
    }
}
