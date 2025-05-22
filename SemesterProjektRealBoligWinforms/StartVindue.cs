namespace SemesterProjektRealBoligWinforms
{
    public partial class StartVindue : Form
    {
        public StartVindue()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void seBoligForsideKnap_Click(object sender, EventArgs e)
        {
            this.Hide();
            new BoligOversigtKunde().ShowDialog();
            this.Show();
        }

        private void loginKnap_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().ShowDialog();
            this.Show();
        }
    }
}
