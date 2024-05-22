using DB.Models;
using System.ComponentModel.DataAnnotations;
using WinFormsApp2.Extensions;
using WinFormsApp2.Services;

namespace WinFormsApp2
{
    public partial class DriverForm : Form
    {
        private readonly ServiceManager _services = new();
        private DifficultyClass? _selectedDificult
            => cbDificultyClass.SelectedItem is null
            ? null
            : (DifficultyClass?)cbDificultyClass.SelectedItem;

        public DriverForm()
        {
            InitializeComponent();
        }

        public async void RoutesForm_Load(object sender, EventArgs e)
        {
            await SetDefaultState();
        }

        private async void btAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateFields(out DriverDTO? driver) || driver is null)
            {
                MessageBox.Show("Поля некорректно заполенны!");
                return;
            }
            await _services.DriverService.CreateDriver(driver);

            await UpdateDGV();

            FieldsClear();
        }

        private void FieldsClear()
        {
            tbFirstName.Text = string.Empty;
            tbLastName.Text = string.Empty;
            tbPatromic.Text = string.Empty;
            tbPhone.Text = string.Empty;
        }

        private bool ValidateFields(out DriverDTO? driver)
        {

            if (_selectedDificult is null)
            {
                driver = null;
                return false;
            }

            driver = new()
            {
                FirstName = tbFirstName.Text,
                LastName = tbLastName.Text,
                Patronymic = tbPatromic.Text,
                Phone = tbPhone.Text,
                Birthdate = dtpBirthdate.Value,
                DifficultyClassId = _selectedDificult.Id
            };

            if(!Validator.TryValidateObject(
                driver,
                new ValidationContext(driver),
                new List<ValidationResult>(),
                true))
            {
                driver = null;
                return false;
            }

            return true;

        }

        private async void btDelete_ClickAsync(object sender, EventArgs e)
        {
            var selectedItem = dgvDrivers.GetSelectedItems<Driver>();
            foreach (Driver driver in selectedItem)
            {
                await _services.DriverService.DeleteDriver(driver.Id);
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
            dgvDrivers.Columns["DifficultyClassId"].Visible = false;

            dgvDrivers.Columns["FirstName"].HeaderText = "Имя";
            dgvDrivers.Columns["LastName"].HeaderText = "Фамилия";
            dgvDrivers.Columns["Patronymic"].HeaderText = "Отчество";
            dgvDrivers.Columns["Birthdate"].HeaderText = "Дата рождения";
            dgvDrivers.Columns["Phone"].HeaderText = "Телефон";
            dgvDrivers.Columns["DifficultyClass"].HeaderText = "Классоность";

        }

        private async void FillCb()
        {
            var types = await _services.DifficultyService.GetClasses();
            cbDificultyClass.DataSource = types;
        }

        private async Task UpdateDGV()
        {
            var routes = await _services.DriverService.GetDrivers();

            dgvDrivers.DataSource = routes;
        }

        private void cbDificultyClass_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
