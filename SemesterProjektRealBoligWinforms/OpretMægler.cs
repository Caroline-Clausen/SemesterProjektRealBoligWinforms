using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projekt1Semester;

namespace SemesterProjektRealBoligWinforms
{
    public partial class OpretMægler : Form
    {
        public OpretMægler()
        {
            InitializeComponent();
        }

        private void opretMæglerKnap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(navnMæglerTekstbox.Text) ||
                string.IsNullOrWhiteSpace(emailMæglerTekstboks.Text) ||
                string.IsNullOrWhiteSpace(telefonMæglerTekstboks.Text) ||
                string.IsNullOrWhiteSpace(brugernavnMæglerTekstboks.Text) ||
                string.IsNullOrWhiteSpace(parswordMæglerTekstboks.Text))
            {
                MessageBox.Show("Udfyld venligst alle felter.");
                return;
            }

            // tilføjelse af ejendomsmægler til liste

            Ejendomsmaegler ejendomsmaeglere = new Ejendomsmaegler(brugernavnMæglerTekstboks.Text, parswordMæglerTekstboks.Text, navnMæglerTekstbox.Text, emailMæglerTekstboks.Text, telefonMæglerTekstboks.Text);
            vistMæglerDataGridView.Show();
        }

        private void afslutOpretMæglerKnap_Click(object sender, EventArgs e)
        {
            OpretMægler.ActiveForm.Close();
        }

        private void fjernMæglerKnap_Click(object sender, EventArgs e)
        {
            //Bruger Id til at finde ejendomsmægler i SQL database
            var ejendomsmaeglerId = vistMæglerDataGridView.SelectedRows[0].Cells[0].Value.ToString();

            // Fjern i database
            // gen indlæs liste 
            // opdater datagridview

        }
    }
}
