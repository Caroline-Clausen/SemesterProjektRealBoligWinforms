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
    public partial class FilterInfoForm : Form
    {
        public BoligSortValues SortValues;

        public FilterInfoForm(BoligSortValues SortValues)
        {
            this.SortValues = SortValues;

            InitializeComponent();
        }

        private void Godkend_Click(object sender, EventArgs e)
        {
            SortValues.Address = AddressBox.Text;
            SortValues.Type = TypeBox.Text;
            SortValues.Area = AreaBox.Text;

            if (SizeMinBox.Text != "")
                SortValues.SizeMin = GetIntFromTextBox(SizeMinBox);
            if (SizeMaxBox.Text != "")
                SortValues.SizeMax = GetIntFromTextBox(SizeMaxBox);
            if (PriceMinBox.Text != "")
                SortValues.PriceMin = GetIntFromTextBox(PriceMinBox);
            if (PriceMaxBox.Text != "")
                SortValues.PriceMax = GetIntFromTextBox(PriceMaxBox);
            if (ShoppingDistanceMinBox.Text != "")
                SortValues.ShoppingDistanceMin = GetIntFromTextBox(ShoppingDistanceMinBox);
            if (ShoppingDistanceMaxBox.Text != "")
                SortValues.ShoppingDistanceMax = GetIntFromTextBox(ShoppingDistanceMaxBox);

            Close();
        }

        private static int GetIntFromTextBox(TextBox box)
        {
            int value;
            if (!int.TryParse(box.Text, out value))
            {
                box.Text = "";  // Remove invalid input from textbox
                return 0;
            }

            return value;
        }

        private void SortValuesForm_Load(object sender, EventArgs e)
        {
            AddressBox.Text = SortValues.Address;
            TypeBox.Text = SortValues.Type;
            AreaBox.Text = SortValues.Area;
            if (SortValues.SizeMin != int.MinValue)
                SizeMinBox.Text = SortValues.SizeMin.ToString();
            if (SortValues.SizeMax != int.MaxValue)
                SizeMaxBox.Text = SortValues.SizeMax.ToString();
            if (SortValues.PriceMin != int.MinValue)
                PriceMinBox.Text = SortValues.PriceMin.ToString();
            if (SortValues.PriceMax != int.MaxValue)
                PriceMaxBox.Text = SortValues.PriceMax.ToString();
            if (SortValues.ShoppingDistanceMin != int.MinValue)
                ShoppingDistanceMinBox.Text = SortValues.ShoppingDistanceMin.ToString();
            if (SortValues.ShoppingDistanceMax != int.MaxValue)
                ShoppingDistanceMaxBox.Text = SortValues.ShoppingDistanceMax.ToString();
        }

        private void pris_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            // det gør at kun tal kommer med. Hvis det bruges andet end tal eller komma, så ignorerer den det.


            // only allow one decimal point
            if ((e.KeyChar == ',') && (((TextBox)sender).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
            // hvis der er mere end et komma i feltet, så ignorerer den det.
        }

        private void int_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            // det gør at kun tal kommer med. 

        }

       
    }
}
