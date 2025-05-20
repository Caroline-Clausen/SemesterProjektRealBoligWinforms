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
    public partial class MæglerInformation : Form
    {
        public Ejendomsmaegler MæglerLokal { get; private set; }

        public MæglerInformation(Ejendomsmaegler ejendomsmaegler)
        {
            InitializeComponent();
            MæglerLokal = ejendomsmaegler;
            navnMæglerTekstbox.Text = ejendomsmaegler.PersonNavn;
            emailMæglerTekstboks.Text = ejendomsmaegler.PersonEmail;
            telefonMæglerTekstboks.Text = ejendomsmaegler.PersonTelefon;
            brugernavnMæglerTekstboks.Text = ejendomsmaegler.EjendomsmaeglerBrugernavn;
            parswordMæglerTekstboks.Text = ejendomsmaegler.EjendomsmaeglerPassword;
        }

        private void mæglerInfoGemKnap_Click(object sender, EventArgs e)
        {
            // tilføjelse af ejendomsmægler til liste
            MæglerLokal.EjendomsmaeglerBrugernavn = brugernavnMæglerTekstboks.Text;
            MæglerLokal.EjendomsmaeglerPassword = parswordMæglerTekstboks.Text;
            MæglerLokal.PersonNavn = navnMæglerTekstbox.Text;
            MæglerLokal.PersonEmail = emailMæglerTekstboks.Text;
            MæglerLokal.PersonTelefon = telefonMæglerTekstboks.Text;

            //gem MæglerLokal i database

            MæglerInformation.ActiveForm.Close();
            // lukker vindue

        }



        private void fortrydMæglerInfoKnap_Click(object sender, EventArgs e)
        {

            //afbryd oprettelse af ejendomsmægler
            MæglerInformation.ActiveForm.Close();
        }

        private void Tekstbox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(navnMæglerTekstbox.Text) ||
               string.IsNullOrWhiteSpace(emailMæglerTekstboks.Text) ||
               string.IsNullOrWhiteSpace(telefonMæglerTekstboks.Text) ||
               string.IsNullOrWhiteSpace(brugernavnMæglerTekstboks.Text) ||
               string.IsNullOrWhiteSpace(parswordMæglerTekstboks.Text))
            {
                mæglerInfoGemKnap.Enabled = false;
            }
            else
            {
                mæglerInfoGemKnap.Enabled = true;
            }
        }

        private void telefonMæglerTekstboks_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            // det gør at kun tal kommer med. 
 
        }
    }
}
