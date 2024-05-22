using DB;
using WinFormsApp2.Extensions;
using WinFormsApp2.Services;

namespace WinFormsApp2
{
    public partial class RoutesForm : Form
    {
        private readonly ServiceManager _services = new();
        private DifficultyClass? _selectedDificult = null;

        public RoutesForm()
        {
            InitializeComponent();
        }

        public async void RoutesForm_Load(object sender, EventArgs e)
        {
            await SetDefaultState();
        }

        private async void btAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateFields(out RouteDTO? route) || route is null)
            {
                MessageBox.Show("Поля некорректно заполенны!");
                return;
            }
            await _services.RouteService.CreateRoute(route);

            await UpdateDGV();

            FieldsClear();
        }

        private void FieldsClear()
        {
            tbDestination.Text = string.Empty;
            tbDistanceKm.Text = string.Empty;
            tbPrice.Text = string.Empty;
        }

        private bool ValidateFields(out RouteDTO? route)
        {
            int distance;
            decimal price;

            bool result =
                (!int.TryParse(tbDistanceKm.Text, out distance)
                || !decimal.TryParse(tbPrice.Text, out price)
                || distance < 0
                || price < 0
                || _selectedDificult is null);

            if (result)
            {
                route = null;
                return false;
            }

            price = decimal.Parse(tbPrice.Text);
            route = new()
            {
                Destination = tbDestination.Text,
                DistanceKm = distance,
                DifficultyClassId = _selectedDificult!.Id,
                Price = price
            };
            return true;
        }

        private async void btDelete_ClickAsync(object sender, EventArgs e)
        {
            var selectedItem = dgvRoutes.GetSelectedItems<Route>();
            foreach (Route route in selectedItem)
            {
                await _services.RouteService.DeleteRoute(route.Id);
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

            dgvRoutes.Columns["Id"].Visible = false;
            dgvRoutes.Columns["DifficultyClassId"].Visible = false;

            dgvRoutes.Columns["Destination"].HeaderText = "Место назначения";
            dgvRoutes.Columns["Price"].HeaderText = "Цена";
            dgvRoutes.Columns["DistanceKm"].HeaderText = "Расстояние";
            dgvRoutes.Columns["DifficultyClass"].HeaderText = "Сложность";

        }

        private async void FillCb()
        {
            var types = await _services.DifficultyService.GetClasses();
            cbDificultyClass.DataSource = types;
        }

        private async Task UpdateDGV()
        {
            var routes = await _services.RouteService.GetRoutes();

            dgvRoutes.DataSource = routes;
        }

        private void cbDificultyClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedDificult = (DifficultyClass?)cbDificultyClass.SelectedItem;
        }
    }
}
