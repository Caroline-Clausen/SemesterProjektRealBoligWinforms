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
    public partial class BoligVisningKunde : Form
    {
        public Bolig BoligLokal { get; private set; } // Bolig objektet der skal vises
        public BoligVisningKunde(Bolig bolig)
        {
            InitializeComponent();
            BoligLokal = bolig;
            adresseTextBox.Text = bolig.Adresse;
            boligTypeTextBox.Text = bolig.Type;
            prisTextBox.Text = bolig.Pris.ToString();
            afstandIndkøbTextBox.Text = bolig.AfstandTilIndkoeb.ToString();
            områdeTextBox.Text = bolig.Område;
            arealTextBox.Text = bolig.Kvadratmeter.ToString();

        }

        private void krLabel_Click(object sender, EventArgs e)
        {

        }

        public void BoligVisningKunde_Load(object sender, EventArgs e)
        {

        }

        private void BoligVisningKunde_Load_1(object sender, EventArgs e)
        {

        }

        private void tilbageBoligKnap_Click(object sender, EventArgs e)
        {
            BoligVisningKunde.ActiveForm.Close();
            
        }
    }
}
