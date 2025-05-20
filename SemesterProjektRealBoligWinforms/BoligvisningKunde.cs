using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
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

        public void krLabel_Click(object sender, EventArgs e)
        {



            //-----------------------------------------------------
            //
            //Her kan systemet sende en e-mail til ejendomsmægler.
            //Det har vi ikke sat op.

        }

       
        private void tilbageBoligKnap_Click(object sender, EventArgs e)
        {
            BoligVisningKunde.ActiveForm.Close();

        }

    }
}
