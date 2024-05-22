namespace WinFormsApp2.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btCar_Click(object sender, EventArgs e)
        {
            new CarForms().Show();
        }

        private void btCargo_Click(object sender, EventArgs e)
        {
            new CarForms().Show();
        }

        private void btDriver_Click(object sender, EventArgs e)
        {
            new DriverForm().Show();
        }

        private void btRoute_Click(object sender, EventArgs e)
        {
            new RoutesForm().Show();
        }

        private void btTrip_Click(object sender, EventArgs e)
        {
            new TripForm().Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
