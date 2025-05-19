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
    public partial class BoligOplysninger : Form
    {
        private Bolig lokalBolig;

        public BoligOplysninger(Bolig bolig)
        {
            InitializeComponent();

            LoadSælgere();

            lokalBolig = bolig;
            AdresseTextBox.Text = lokalBolig.Adresse;
            AfstandIndkøbTextBox.Text = lokalBolig.AfstandTilIndkoeb.ToString();
            ArealText.Text = lokalBolig.Kvadratmeter.ToString();
            OmrådeTextBox.Text = lokalBolig.Område;
            PrisTextBox.Text = lokalBolig.Pris.ToString();
            BoligTypeTextBox.Text = lokalBolig.Type;

            for (int i = 0; i < SælgerComboBox.Items.Count; i++)
            {
                if (((Saelger)SælgerComboBox.Items[i]).SaelgerID == lokalBolig.SaelgerID)
                {
                    SælgerComboBox.SelectedIndex = i;
                    break;
                }
            }
            KontrollerAllData();
        }

        private void LoadSælgere()
        {
            SælgerRepository sælgerRepository = new SælgerRepository();
            List<Saelger> sælgere = sælgerRepository.HentSælgere();
            SælgerComboBox.Items.AddRange(sælgere.ToArray());
            SælgerComboBox.DisplayMember = "PersonNavn";
        }

        private void GemButton_Click(object sender, EventArgs e)
        {

            lokalBolig.Adresse = AdresseTextBox.Text;
            lokalBolig.Kvadratmeter = Convert.ToInt32(ArealText.Text);
            lokalBolig.Type = BoligTypeTextBox.Text;
            lokalBolig.Pris = Convert.ToInt32(PrisTextBox.Text);
            lokalBolig.AfstandTilIndkoeb = Convert.ToInt32(AfstandIndkøbTextBox.Text);
            lokalBolig.Område = OmrådeTextBox.Text;
            lokalBolig.SaelgerID = ((Saelger)SælgerComboBox.SelectedItem).SaelgerID;

            this.Close();
        }

        private void FortrydButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            KontrollerAllData();
        }

        private void SælgerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            KontrollerAllData();
        }

        private void KontrollerAllData()
        {
            if (AdresseTextBox.Text == "" ||
                AfstandIndkøbTextBox.Text == "" ||
                ArealText.Text == "" ||
                OmrådeTextBox.Text == "" ||
                PrisTextBox.Text == "" ||
                BoligTypeTextBox.Text == "" ||
                SælgerComboBox.SelectedItem == null)
            {
                GemButton.Enabled = false;
            }
            else
            {
                GemButton.Enabled = true;
            }
        }
    }
}
