using DB.Models;
using System.ComponentModel.DataAnnotations;
using WinFormsApp2.DTO;
using WinFormsApp2.Extensions;
using WinFormsApp2.Services;

namespace WinFormsApp2
{
    public partial class CarForms : Form
    {
        private readonly ServiceManager _serviceManager = new();

        public CarForms()
        {
            InitializeComponent();
        }

        private async void btAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateFields(out CarDTO? car))
            {
                MessageBox.Show("Некорректное значение поля");
                return;
            }
            await _serviceManager.CarService.CreateCar(car!);
            UpdateTable();
            ClearFields();
        }

        private void ClearFields()
        {
            tbCapacity.Text = string.Empty;
            tbNumber.Text = string.Empty;
            tbBrand.Text = string.Empty;
        }

        private bool ValidateFields(out CarDTO? car)
        {
            bool result = int.TryParse(tbCapacity.Text, out int capacity);

            car = new()
            {
                Brand = tbBrand.Text,
                Number = tbNumber.Text,
                LoadCapacityKg = result ? capacity : -1
            };

            if (!Validator.TryValidateObject(
                car,
                new ValidationContext(car),
                new List<ValidationResult>(),
                true))
            {
                car = null;
                return false;
            }

            return true;

        }


        private void btUpdateTable_Click(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private async void UpdateTable()
        {
            var types = await _serviceManager.CarService.GetCars();
            dgvCars.DataSource = types;
        }

        private void SetDefaultState()
        {
            UpdateTable();
            dgvCars.Columns["Id"].Visible = false;
            dgvCars.Columns["Brand"].HeaderCell.Value = "Марка";
            dgvCars.Columns["Number"].HeaderCell.Value = "Номер";
            dgvCars.Columns["LoadCapacityKg"].HeaderCell.Value = "Грузоподъёмность кг";
        }

        private async void btDelete_Click(object sender, EventArgs e)
        {
            foreach (var car in dgvCars.GetSelectedItems<Car>())
                await _serviceManager.CarService.DeleteCar(car.Id);
            UpdateTable();
        }

        private void CarForms_Load(object sender, EventArgs e)
        {
            SetDefaultState();
        }
    }
}
