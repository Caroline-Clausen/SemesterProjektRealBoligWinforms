using DataAccess;
using Microsoft.Data.SqlClient;
using Projekt1Semester;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemesterProjektRealBoligWinforms
{
    public class BoligSortValues
    {
        public String Address = "";
        public String Type = "";
        public String Area = "";
    }

    public partial class RealtorForm : Form
    {
        BoligSortValues SortValues = new BoligSortValues();
        DataTable Data;
        DataTable DataSorted;

        public RealtorForm()
        {
            InitializeComponent();
        }

        private void RealtorForm_Load(object? sender, EventArgs e)
        {
            RefreshDataTable(sender, e);
        }

        private void RefreshDataTable(object? sender, EventArgs e)
        {
            // Get all data
            Data = DBConnection.GetHomesTable();
            // Resort new data
            SortDataTable(sender, e);
        }

        private void SortDataTable(object? sender, EventArgs e)
        {
            // Sort data
            IEnumerable<DataRow> SortQuery =
                from bolig in Data.AsEnumerable()
                where bolig.Field<String>("adresse").Contains(SortValues.Address)
                where bolig.Field<String>("type").Contains(SortValues.Type)
                where bolig.Field<String>("område").Contains(SortValues.Area)
                select bolig;

            DataSorted = SortQuery.CopyToDataTable<DataRow>();
            HomesGridView.DataSource = DataSorted;
            HomesGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void RegisterHomeButton_Click(object? sender, EventArgs e)
        {

        }

        private void EditHomeButton_Click(object? sender, EventArgs e)
        {

        }

        private void SortListButton_Click(object? sender, EventArgs e)
        {
            SortValuesForm form = new SortValuesForm(SortValues);
            form.FormClosing += SortDataTable;
            form.Show();
        }

        private void ExportListButton_MouseClick(object? sender, MouseEventArgs e)
        {

        }
    }
}
