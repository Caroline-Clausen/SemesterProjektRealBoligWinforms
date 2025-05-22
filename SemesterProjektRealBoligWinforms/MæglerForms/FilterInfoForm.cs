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
            String? statusStr = StatusComboBox.GetItemText(StatusComboBox.SelectedItem);
            if (statusStr != null && statusStr != "")
            {
                if (statusStr == "alle")
                    SortValues.Status = "";
                else
                    SortValues.Status = statusStr;
            }
            if (statusStr == "solgt")
            {
                SortValues.SoldFromDate = SalePeriodFromDateTimePicker.Value; ;
                SortValues.SoldToDate = SalePeriodToDateTimePicker.Value;
            } else
            {
                SortValues.SoldFromDate = null;
                SortValues.SoldToDate = null;
            }
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
            switch (SortValues.Status)
            {
                case "til salg":
                    StatusComboBox.SelectedIndex = 0;
                    break;
                case "solgt":
                    StatusComboBox.SelectedIndex = 1;
                    break;
                default:
                    StatusComboBox.SelectedIndex = 2;
                    break;
            }
            if (SortValues.SoldFromDate != null)
                SalePeriodFromDateTimePicker.Value = (DateTime)SortValues.SoldFromDate;
            if (SortValues.SoldToDate != null)
                SalePeriodToDateTimePicker.Value = (DateTime)SortValues.SoldToDate;

            // Hide/show sales period filter options depending on relevancy
            StatusComboBox_SelectedIndexChanged(sender, e);
        }

        private void pris_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
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
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            // det gør at kun tal kommer med. 

        }

        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // We check if Status filter is set to sold.
            // Only then is it relevant to also search for a time and date.
            bool showSalesPeriod = StatusComboBox.SelectedIndex == 1;

            SalePeriodLabel.Visible = showSalesPeriod;
            SaleTimePeriodValues.Visible = showSalesPeriod;
        }
    }
}
