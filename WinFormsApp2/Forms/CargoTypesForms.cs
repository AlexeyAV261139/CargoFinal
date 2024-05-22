using DB.Models;
using WinFormsApp2.Services;

namespace WinFormsApp2
{
    public partial class CargoTypesForms : Form
    {
        private readonly ServiceManager _serviceManager = new();

        public CargoTypesForms()
        {
            InitializeComponent();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            _serviceManager.CargoTypeService.CreateCargoType(tbName.Text);
            tbName.Text = "";
            UpdateTable();
        }

        private void btUpdateTable_Click(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private async void UpdateTable()
        {
            var types = await _serviceManager.CargoTypeService.GetCargoTypes();
            FillTable(types);
        }

        private void FillTable(List<CargoTypeEntity> types)
        {
            dgvTypes.DataSource = types;
            dgvTypes.Columns["Id"].Visible = false;
            dgvTypes.Columns["Name"].HeaderCell.Value = "Наименование";
        }

        private async void btDelete_Click(object sender, EventArgs e)
        {
            foreach (Guid id in GetSelectedIds())
                await _serviceManager.CargoTypeService.DeleteCargoType(id);
            UpdateTable();
        }

        private IEnumerable<Guid> GetSelectedIds()
        {
            foreach (DataGridViewRow item in dgvTypes.SelectedRows)
            {
                var type = (CargoTypeEntity)item.DataBoundItem;
                yield return type.Id;
            }
        }
        
    }
}
