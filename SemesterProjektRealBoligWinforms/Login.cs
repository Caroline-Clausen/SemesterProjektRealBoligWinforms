using BusinessLayer;
using DataAccess;
using Projekt1Semester;
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

        private void WrongPassword()
        {
            MessageBox.Show("Forkert brugernavn eller kodeord.");
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
        }

        private void ejendomsmæglerGodkendKanp_MouseClick(object sender, MouseEventArgs e)
        {
            // Retrieve username and password from textboxes
            String username = ejendomsmæglerBrugernavnTekstbox.Text;
            String password = EjendomsmæglerPasswordTekstbox.Text;


            // Try to authenticate with provided login
            Ejendomsmaegler? account;
            try
            {
                account = Authenticator.LoginRealtor(username, password);
            } catch (Exception ex)
            {
                // Exception doesn't ocur if the password or username was incorect
                // Most likely an error occurs if there was a problem connecting with the database
                MessageBox.Show(ex.Message);
                return;
            }

            // If we get a null value, we know authentication failed.
            if (account == null)
            {
                WrongPassword();
                return;
            }

            // Show realtor page
            RealtorForm form = new();
            form.Show();
            this.Hide();
        }


        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
