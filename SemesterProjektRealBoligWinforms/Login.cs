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
            // Tjekker om brugernavnet og kodeordet er korrekt
            // Her skal brugernavn og password kontrolleres med databasen 
            if (adminBrugernavnTekstbox.Text == "admin" && adminPasswordTekstbox.Text == "admin")
            {
                // Opretter en instans af AdminForm og viser den
                OpretMægler opretMægler = new OpretMægler();
                opretMægler.Show();
                this.Hide(); // Skjuler loginvinduet
            }
            else
            {
                MessageBox.Show("Forkert brugernavn eller kodeord.");
            }
        }
    }
}
