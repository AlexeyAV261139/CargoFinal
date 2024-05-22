using DB;
using DB.Models;
using System.ComponentModel.DataAnnotations;
using WinFormsApp2.DTO;
using WinFormsApp2.Extensions;
using WinFormsApp2.Services;

namespace WinFormsApp2
{
    public partial class TripForm : Form
    {
        private readonly ServiceManager _services = new();

        private Route? _selectedRoute
            => cbRoute.SelectedItem is null
            ? null
            : (Route)cbRoute.SelectedItem;

        private Driver? _selectedDriver
            => cbDriver.SelectedItem is null
            ? null
            : (Driver)cbDriver.SelectedItem;

        private Car? _selectedCar
            => cbCar.SelectedItem is null
            ? null
            : (Car)cbCar.SelectedItem;

        private Cargo? _selectedCargo
            => cbCargo is null
            ? null
            : (Cargo)cbCargo.SelectedItem!;

        public TripForm()
        {
            InitializeComponent();
        }

        public async void RoutesForm_Load(object sender, EventArgs e)
        {
            await SetDefaultState();
        }

        private async void btAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateFields(out TripDTO? trip) || trip is null)
            {
                MessageBox.Show("Поля некорректно заполенны!");
                return;
            }
            await _services.TripService.CreateTrip(trip);

            await UpdateDGV();

            FieldsClear();
        }

        private void FieldsClear()
        {
            dtpEnd.Text = string.Empty;
            dtpStart.Text = string.Empty;
        }

        private bool ValidateFields(out TripDTO? trip)
        {

            if (_selectedCar is null
                || _selectedCargo is null
                || _selectedDriver is null
                || _selectedRoute is null)
            {
                trip = null;
                return false;
            }

            trip = new()
            {
                Start = dtpStart.Value,
                End = dtpEnd.Value,
                CargoId = _selectedCargo.Id,
                CarId = _selectedCar.Id,
                RouteId = _selectedRoute.Id,
                DriverId = _selectedDriver.Id,
            };

            if (!Validator.TryValidateObject(
                trip,
                new ValidationContext(trip),
                new List<ValidationResult>(),
                true))
            {
                trip = null;
                return false;
            }

            return true;

        }

        private async void btDelete_ClickAsync(object sender, EventArgs e)
        {
            var selectedItem = dgvDrivers.GetSelectedItems<Trip>();
            foreach (Trip trip in selectedItem)
            {
                await _services.TripService.DeleteTrip(trip.Id);
            }
            await UpdateDGV();
        }

        private async void btUpdateTable_Click(object sender, EventArgs e)
        {
            await UpdateDGV();

        }

        private async Task SetDefaultState()
        {
            FillCb();

            await UpdateDGV();

            dgvDrivers.Columns["Id"].Visible = false;
            dgvDrivers.Columns["RouteId"].Visible = false;
            dgvDrivers.Columns["DriverId"].Visible = false;
            dgvDrivers.Columns["CarId"].Visible = false;
            dgvDrivers.Columns["CargoId"].Visible = false;

            dgvDrivers.Columns["Start"].HeaderText = "C";
            dgvDrivers.Columns["End"].HeaderText = "ПО";
            dgvDrivers.Columns["Route"].HeaderText = "Маршрут";
            dgvDrivers.Columns["Driver"].HeaderText = "Водитель";
            dgvDrivers.Columns["Car"].HeaderText = "Авто";
            dgvDrivers.Columns["Cargo"].HeaderText = "Груз";

        }
       
        private async void FillCb()
        {
            try
            {
                cbCar.DataSource = await _services.CarService.GetCars();
                cbCargo.DataSource = await _services.CargoService.GetCargos();
                cbDriver.DataSource = await _services.DriverService.GetDrivers();
                cbRoute.DataSource = await _services.RouteService.GetRoutes();
            }
            catch
            { MessageBox.Show("Упс... Что-то пошло не так."); }
        }

        private async Task UpdateDGV()
           => dgvDrivers.DataSource = await _services.TripService.GetTrips();
    }
}
