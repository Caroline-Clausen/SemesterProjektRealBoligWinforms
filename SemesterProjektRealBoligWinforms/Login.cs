using BusinessLayer;
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

        private void godkendAdminKnap_Click(object sender, EventArgs e)
        {
            // Retrieve username and password from textboxes
            String username = adminBrugernavnTekstbox.Text;
            String password = adminPasswordTekstbox.Text;

            // Try to authenticate with provided login
            Administrator? account = Authenticator.LoginAdmin(username, password);

            // If we get a null value, we know authentication failed.
            if (account == null)
            {
                MessageBox.Show("Forkert brugernavn eller kodeord.");
                return;
            }

            // Show admin form
            OpretMægler opretMægler = new OpretMægler();
            opretMægler.Show();
            this.Hide(); // Hide login form
        }
    }
}
