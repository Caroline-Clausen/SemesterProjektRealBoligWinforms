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
            MæglerInformation mæglerInformation = new MæglerInformation(new Ejendomsmaegler());
            mæglerInformation.Show();

            // opretter ny ejendomsmægler og tilføjer til datagridview

            // der skal være en metode til at tilføje ejendomsmægler til databasen 
        }

        private void afslutOpretMæglerKnap_Click(object sender, EventArgs e)
        {
            OpretMægler.ActiveForm.Close();
            // lukker vindue
        }

        private void fjernMæglerKnap_Click(object sender, EventArgs e)
        {
            //Bruger Id til at finde ejendomsmægler i SQL database
            var ejendomsmaeglerId = vistMæglerDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            //ID sendes til database for at finde ejendomsmægler
            // Fjern i database
            // gen indlæs liste 
            // opdater datagridview
        }

        private void opdaterMæglerListeKnap_Click(object sender, EventArgs e)
        {
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


        }
    }
}
