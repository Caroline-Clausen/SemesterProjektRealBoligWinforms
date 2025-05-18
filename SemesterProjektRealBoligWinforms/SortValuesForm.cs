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
    public partial class SortValuesForm : Form
    {
        public Bolig SortValues;

        public SortValuesForm(Bolig SortValues)
        {
            this.SortValues = SortValues;

            InitializeComponent();
        }

        private void Godkend_Click(object sender, EventArgs e)
        {
            SortValues.Adresse = AddressBox.Text;
            SortValues.Kvadratmeter = Convert.ToDouble(SizeBox.Text);
            SortValues.Type = TypeBox.Text;
            SortValues.Pris = Convert.ToDouble(PriceBox.Text);
            SortValues.AfstandTilIndkoeb = Convert.ToDouble(ShoppingDistanceBox.Text);
            SortValues.Område = AreaBox.Text;

            Close();
        }
    }
}
