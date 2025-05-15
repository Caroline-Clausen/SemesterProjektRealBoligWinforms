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
    public partial class OpretMægler : Form
    {
        public OpretMægler()
        {
            InitializeComponent();
        }

        private void opretMæglerKnap_Click(object sender, EventArgs e)
        {
            // viser vindue til at oprette ejendomsmægler
            MæglerInformation mæglerInformation = new MæglerInformation(new Ejendomsmaegler());
            mæglerInformation.ShowDialog();

            EjendomsmæglerRepository ejendomsmæglerRepository = new EjendomsmæglerRepository();
            ejendomsmæglerRepository.TilføjEjendomsmægler(mæglerInformation.MæglerLokal);
            opdaterMæglerListeKnap_Click(sender, e);

        }

        private void afslutOpretMæglerKnap_Click(object sender, EventArgs e)
        {
            OpretMægler.ActiveForm.Close();
            // lukker vindue
        }

        private void fjernMæglerKnap_Click(object sender, EventArgs e)
        {
            //Bruger Id til at finde ejendomsmægler i SQL database

            EjendomsmæglerRepository ejendomsmæglerRepository = new EjendomsmæglerRepository();

            var ejendomsmaeglerId = (int)vistMæglerDataGridView.SelectedRows[0].Cells[0].Value;

            ejendomsmæglerRepository.FjernEjendomsmægler(ejendomsmaeglerId);

            // opdater datagridview over mæglere
            opdaterMæglerListeKnap_Click(sender, e);

            //vistMæglerDataGridView.Rows.Remove(vistMæglerDataGridView.SelectedRows[0]); længere oppe sættes værdier og grit opdateres

            //ikke nødvendigt at slette celler i datagridview, da det opdateres ved at hente ny liste fra databasen
            //for (int i = 1; i < vistMæglerDataGridView.SelectedRows[0].Cells.Count; i++)
            //{
            //    vistMæglerDataGridView.SelectedRows[0].Cells[i].Value = null;
            //}
            // Eventuelt opdater databasen og visningen, hvis nødvendigt

        }

        private void opdaterMæglerListeKnap_Click(object sender, EventArgs e)
        {
            EjendomsmæglerRepository ejendomsmæglerRepository = new EjendomsmæglerRepository();
            List<Ejendomsmaegler> ejendomsmæglere = ejendomsmæglerRepository.HentEjendomsmaeglere();
            vistMæglerDataGridView.DataSource = ejendomsmæglere;

            vistMæglerDataGridView.Update();
            // opdater datagridview over mæglere

        }

        private void redigerMæglerKnap_Click(object sender, EventArgs e)
        {
            //Bruger Id til at finde ejendomsmægler i SQL database
            var ejendomsmaeglerId = (Ejendomsmaegler)vistMæglerDataGridView.SelectedRows[0].DataBoundItem;

            //ID sendes til database for at finde ejendomsmægler
            // vise data i nyt vindue

            MæglerInformation mæglerInformation = new MæglerInformation(ejendomsmaeglerId);


            mæglerInformation.Show();
        }

        private void OpretMægler_Load(object sender, EventArgs e)
        {
            opdaterMæglerListeKnap_Click(sender, e);
        }

        private void vistMæglerDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
