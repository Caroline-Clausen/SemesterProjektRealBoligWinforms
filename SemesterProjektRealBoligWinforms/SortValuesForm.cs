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
        public BoligSortValues SortValues;

        public SortValuesForm(BoligSortValues SortValues)
        {
            this.SortValues = SortValues;

            InitializeComponent();
        }

        private void Godkend_Click(object sender, EventArgs e)
        {
            SortValues.Address = AddressBox.Text;
            SortValues.Type = TypeBox.Text;
            SortValues.Area = AreaBox.Text;

            Close();
        }

        private void SortValuesForm_Load(object sender, EventArgs e)
        {
            AddressBox.Text = SortValues.Address;
            TypeBox.Text = SortValues.Type;
            AreaBox.Text = SortValues.Area;
        }
    }
}
