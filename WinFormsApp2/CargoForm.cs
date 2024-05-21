using DB.Models;
using WinFormsApp2.Services;

namespace WinFormsApp2
{
    public partial class CargoForm : Form
    {
        private readonly ServiceManager _services = new();
        private CargoTypeEntity? _type = null;

        public CargoForm()
        {
            InitializeComponent();
        }

        private async void CargoForm_Load(object sender, EventArgs e)
        {
            await SetDefaultState();
        }

        private async void btAdd_Click(object sender, EventArgs e)
        {
            if (_type == null)
                return;

            CargoDTO cargo = new()
            {
                Reequipments = tbRequirements.Text,
                TypeId = _type.Id,
            };

            await _services.CargoService.CreateCargo(cargo);

            cbCargoType.SelectedItem = null;
            tbRequirements.Text = string.Empty;

            await UpdateDGV();
        }

        private async void FillCb()
        {
            var types = await _services.CargoTypeService.GetCargoTypes();
            cbCargoType.DataSource = types;
        }

        private async void btUpdateTable_ClickAsync(object sender, EventArgs e)
        {
            FillCb();
            await UpdateDGV();
        }

        private async Task SetDefaultState()
        {
            FillCb();

            await UpdateDGV();

            dgvCargos.Columns["Id"].Visible = false;
            dgvCargos.Columns["CargoTypeId"].Visible = false;
            dgvCargos.Columns["Requirements"].HeaderText = "Требования";
            dgvCargos.Columns["CargoType"].HeaderText = "Тип груза";
        }

        private async Task UpdateDGV()
        {
            var cargos = await _services.CargoService.GetCargos();

            dgvCargos.DataSource = cargos;
        }

        private void cbCargoType_SelectedIndexChanged(object sender, EventArgs e)
        {
            _type = (CargoTypeEntity?)cbCargoType.SelectedItem;
        }

        private async void btDelete_Click(object sender, EventArgs e)
        {
            foreach (var cargo in dgvCargos.GetSelectedItems<CargoEntity>())
            {
                await _services.CargoService.DeleteCargo(cargo.Id);
            }
            await UpdateDGV();
        }

    }
}
