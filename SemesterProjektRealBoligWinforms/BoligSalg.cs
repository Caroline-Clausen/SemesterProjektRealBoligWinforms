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
        
        public salgBolig(Bolig bolig) // har jeg sat ind
        {
            InitializeComponent();
           
            LoadSælgere(); // har jeg sat ind
        
            lokalBolig = bolig;
            AdresseTextBox.Text = lokalBolig.Adresse;

            for (int i = 0; i < SælgerComboBox.Items.Count; i++)
            {
                if (((Saelger)SælgerComboBox.Items[i]).SaelgerID == lokalBolig.SaelgerID)
                {
                    SælgerComboBox.SelectedIndex = i;
                    break;
                }
            }
        
            //for (int j = 0;j<koeberComboBox.Items.Count;j++)
            //{
            //    if (((Koeber)koeberComboBox.Items[j]).KoeberID == lokalBolig.KoeberID)
            //    {
            //        koeberComboBox.SelectedIndex = j;
            //        break;
            //    }
            //}
        }

        private void boligTableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void LoadSælgere() // har jeg sat ind
        {
            SælgerRepository sælgerRepository = new SælgerRepository();
            List<Saelger> sælgere = sælgerRepository.HentSælgere();
            SælgerComboBox.Items.AddRange(sælgere.ToArray());
            SælgerComboBox.DisplayMember = "PersonNavn";
        }
    }
}
