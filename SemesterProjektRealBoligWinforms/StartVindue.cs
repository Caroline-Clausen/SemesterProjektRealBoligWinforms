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
            Program.PushForm(new BoligOversigtKunde());
        }

        private void loginKnap_Click(object sender, EventArgs e)
        {
            Program.PushForm(new Login());
        }
    }
}
