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
    public partial class RealtorForm : Form
    {
        BoligSortValues SortValues = new BoligSortValues();
        List<Bolig> Data;
        List<Bolig> DataSorted;

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
            BoligRepository boligRepository = new BoligRepository();
            Data = boligRepository.HentBoliger();
            // Resort new data
            SortDataTable(sender, e);
        }

        private void SortDataTable(object? sender, EventArgs e)
        {
            // Sort data
            IEnumerable<Bolig> sortQuery =
                from bolig in Data
                where bolig.Adresse.Contains(SortValues.Address)
                where bolig.Type.Contains(SortValues.Type)
                where bolig.Område.Contains(SortValues.Area)
                where bolig.Kvadratmeter >= SortValues.SizeMin
                where bolig.Kvadratmeter <= SortValues.SizeMax
                where bolig.Pris >= SortValues.PriceMin
                where bolig.Pris <= SortValues.PriceMax
                where bolig.AfstandTilIndkoeb >= SortValues.ShoppingDistanceMin
                where bolig.AfstandTilIndkoeb <= SortValues.ShoppingDistanceMax
                select bolig;

            DataSorted = sortQuery.ToList();
            HomesGridView.DataSource = DataSorted;
            HomesGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void RegisterHomeButton_Click(object? sender, EventArgs e)
        {
            Bolig bolig = new Bolig();
            BoligOplysninger boligOplysninger = new BoligOplysninger(bolig);

            this.Hide();
            boligOplysninger.ShowDialog();
            this.Show();

            if (boligOplysninger.DialogResult == DialogResult.OK)
            {
                BoligRepository boligRepository = new BoligRepository();
                boligRepository.TilføjBolig(bolig);
            }

            RefreshDataTable(sender, e);
        }

        private void EditHomeButton_Click(object? sender, EventArgs e)
        {
            Bolig bolig = (Bolig)HomesGridView.SelectedRows[0].DataBoundItem;
            BoligOplysninger boligOplysninger = new BoligOplysninger(bolig);

            this.Hide();
            boligOplysninger.ShowDialog();
            this.Show();

            if (boligOplysninger.DialogResult == DialogResult.OK)
            {
                BoligRepository boligRepository = new BoligRepository();
                boligRepository.OpdaterBolig(bolig);
            }

            RefreshDataTable(sender, e);
        }

        private void SortListButton_Click(object? sender, EventArgs e)
        {
            FilterInfoForm form = new FilterInfoForm(SortValues);
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void ExportListButton_MouseClick(object? sender, MouseEventArgs e)
        {

        }

        private void sletBoligButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Er du sikker på at du vil slette denne bolig?", "Slet bolig", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            BoligRepository boligRepository = new BoligRepository();
            var boligID = (int)HomesGridView.SelectedRows[0].Cells[0].Value;
            boligRepository.FjernBolig(boligID);
            RefreshDataTable(sender, e);

        }
    }
    public class BoligSortValues
    {
        public String Address = "";
        public String Type = "";
        public String Area = "";
        public int SizeMin = int.MinValue;
        public int SizeMax = int.MaxValue;
        public int PriceMin = int.MinValue;
        public int PriceMax = int.MaxValue;
        public int ShoppingDistanceMin = int.MinValue;
        public int ShoppingDistanceMax = int.MaxValue;
    }
}
