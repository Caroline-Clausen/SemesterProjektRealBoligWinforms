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

        private void boligKundeGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BoligOversigtKunde_Load(object sender, EventArgs e)
        {
            BoligRepository boligRepository = new BoligRepository();
            List<Bolig> boliger = boligRepository.HentBoliger();
            boligKundeGridView.DataSource = boliger;

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
