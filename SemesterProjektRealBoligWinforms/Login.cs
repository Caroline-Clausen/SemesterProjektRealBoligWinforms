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
            String username = adminBrugernavnTekstbox.Text;
            String password = adminPasswordTekstbox.Text;



            // Tjekker om brugernavnet og kodeordet er korrekt
            // Her skal brugernavn og password kontrolleres med databasen evt skal der her være en liste med oprettede brugere 

            // For nuværende er det hardkodet til "admin" og "admin"
            // I en rigtig applikation skal du bruge en database til at gemme og kontrollere brugernavne og adgangskoder
            // Dette er kun til demonstration

            // indsæt database kode her eller metode til at hente brugernavn og password fra en database

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
