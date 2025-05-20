using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using Projekt1Semester;

namespace SemesterProjektRealBoligWinforms
{
    public partial class BoligOversigtKunde : Form
    {
        public BoligOversigtKunde()
        {
            InitializeComponent();
        }

      
        private void BoligOversigtKunde_Load(object sender, EventArgs e)
        {
            BoligRepository boligRepository = new BoligRepository();

            List<string> områder = boligRepository.HentOmråder();
            områder.Add(" Alle");
            områdeComboBox.Items.AddRange(områder.ToArray());
            områdeComboBox.Update();
            områdeComboBox.SelectedIndex = 0;

        }

        private void områdeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BoligRepository boligRepository = new BoligRepository();
            string valgtOmråde = områdeComboBox.SelectedItem.ToString();
            if (valgtOmråde == " Alle")
            {
                List<Bolig> boliger = boligRepository.HentBoliger();
                boligBindingSource.DataSource = boliger;
            }
            else
            {
                List<Bolig> boliger = boligRepository.HentBoligerOmråde(valgtOmråde);
                boligBindingSource.DataSource = boliger;

                boligBindingSource.Filter = $"Område = '{valgtOmråde}'";
            }

            boligKundeGridView.Update();
        }

        private void seBoligKnap_Click(object sender, EventArgs e)
        {

            var boligId = (Bolig)boligKundeGridView.SelectedRows[0].DataBoundItem;
            BoligVisningKunde boligVisningKunde = new BoligVisningKunde(boligId);

            this.Hide();
            boligVisningKunde.ShowDialog();
            this.Show();
        }

        private void afslutKnap_Click(object sender, EventArgs e)
        {
            BoligOversigtKunde.ActiveForm.Close();
        }
    }
}
