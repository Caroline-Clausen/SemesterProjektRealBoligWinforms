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
    public partial class salgBolig : Form
    {
        private Bolig lokalBolig;

        public salgBolig(Bolig bolig)
        {
            InitializeComponent();

            LoadSælgere();
            HentEjendomsmaeglere();

            HentKøber();
            lokalBolig = bolig;
            AdresseTextBox.Text = lokalBolig.Adresse;

            for (int i = 0; i < saelgerComboBox.Items.Count; i++)
            {
                if (((Saelger)saelgerComboBox.Items[i]).SaelgerID == lokalBolig.SaelgerID)
                {
                    saelgerComboBox.SelectedIndex = i;
                    break;
                }
            }

            //hvis ikke køber er på listen skal den tilføjes

        }

       
        private void GemButton_Click(object sender, EventArgs e)
        {
            BoligRepository boligRepository = new BoligRepository();
            boligRepository.SætStatus(lokalBolig.BoligID, "solgt");
            Salg salg = new Salg();
            salg.BoligID = lokalBolig.BoligID;
            salg.SaelgerID = ((Saelger)saelgerComboBox.SelectedItem).SaelgerID;
            salg.EjendomsmaeglerID = ((Ejendomsmaegler)mæglerComboBox.SelectedItem).EjendomsmaeglerID;
            salg.KoeberID = ((Koeber)koeberComboBox.SelectedItem).KoeberID;
            salg.Salgsdato = salgsDatoDateTimePicker.Value;
            salg.Salgspris = Convert.ToDouble(prisTextBox.Text);
            SalgRepository salgRepository = new SalgRepository();
            salgRepository.OpretSalg(salg);
            this.Close();
        }

        private void LoadSælgere()
        {
            SælgerRepository sælgerRepository = new SælgerRepository();
            List<Saelger> sælgere = sælgerRepository.HentSælgere();
            saelgerComboBox.Items.AddRange(sælgere.ToArray());
            saelgerComboBox.DisplayMember = "Navn";
        }

        private void HentEjendomsmaeglere()
        {
            // henter ejendomsmæglere fra databasen, tilføjer dem til comboBox og sætter viser PersonNavn
            EjendomsmæglerRepository ejendomsmæglerRepository = new EjendomsmæglerRepository();
            List<Ejendomsmaegler> ejendomsmæglere = ejendomsmæglerRepository.HentEjendomsmaeglere();
            mæglerComboBox.Items.AddRange(ejendomsmæglere.ToArray());
            mæglerComboBox.DisplayMember = "Navn";
        }

        private void HentKøber()
        {
            //Henter køber fra databasen og tilføjer dem til køberComboBox
            KøberRepository køberRepository = new KøberRepository();
            List<Koeber> købere = køberRepository.Hentkøbere();
            koeberComboBox.Items.AddRange(købere.ToArray());
            koeberComboBox.DisplayMember = "Navn";
        }

        private void prisTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            // det gør at kun tal kommer med. Hvis det bruges andet end tal eller komma, så ignorerer den det.


            // only allow one decimal point
            if ((e.KeyChar == ',') && (((TextBox)sender).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
            // hvis der er mere end et komma i feltet, så ignorerer den det.
        }
    }
}
