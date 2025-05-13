using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemesterProjektRealBoligWinforms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void godkendAdminKnap_Click(object sender, EventArgs e)
        {
            // 1) Hent input
            string user = adminBrugernavnTekstbox.Text.Trim();
            string pass = adminPasswordTekstbox.Text.Trim();

            // 2) Simpel UI-validering
            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show(
                  "Indtast både brugernavn og adgangskode.",
                  "Manglende input",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Warning
                );
                return;
            }

            // 3) Kald databasen via Repository
            var repo = new AdministratorRepository();
            bool succes = repo.Authenticate(user, pass);

            // 4) Håndter login-resultatet
            if (succes)
            {
                // Hvis login OK, åbn næste form
                OpretMægler opretMægler = new();
                opretMægler.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(
                  "Forkert brugernavn eller kodeord.",
                  "Login-fejl",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error
                );
                adminPasswordTekstbox.Clear();
                adminPasswordTekstbox.Focus();
            }
        }


        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
