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
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemesterProjektRealBoligWinforms
{
    public partial class RealtorForm : Form
    {
        BoligSortValues SortValues = new BoligSortValues();
        List<BoligMedSælger>? Data;
        List<BoligMedSælger>? DataSorted;
        

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
            Data = boligRepository.HentBoligerMedSælger();
            // Resort new data
            SortDataTable(sender, e);
        }

        private void SortDataTable(object? sender, EventArgs e)
        {
            // Sort data
            IEnumerable<BoligMedSælger> sortQuery =
                from bolig in Data
                where bolig.Adresse.Contains(SortValues.Address)
                where bolig.Type.Contains(SortValues.Type)
                where bolig.Område.Contains(SortValues.Area)
                where bolig.Status.Contains(SortValues.Status)
                where bolig.Kvadratmeter >= SortValues.SizeMin
                where bolig.Kvadratmeter <= SortValues.SizeMax
                where bolig.Pris >= SortValues.PriceMin
                where bolig.Pris <= SortValues.PriceMax
                where bolig.AfstandTilIndkoeb >= SortValues.ShoppingDistanceMin
                where bolig.AfstandTilIndkoeb <= SortValues.ShoppingDistanceMax
                select bolig;

            DataSorted = sortQuery.ToList();

            // If we sort by sold homes, we also sort by time of sale
            if (SortValues.Status == "solgt")
            {
                DataSorted.RemoveAll(bolig =>
                {
                    Salg? salg = SalgRepository.HentSalg(bolig.BoligID);
                    if (salg == null)
                        return true; // Leave in list, if we couldn't find sale record

                    return SortValues.SoldFromDate > salg.Salgsdato ||
                           SortValues.SoldToDate < salg.Salgsdato;
                });
            }

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
            BoligRepository boligRepository = new BoligRepository();
            Bolig bolig = boligRepository.HentBolig(((BoligMedSælger)HomesGridView.SelectedRows[0].DataBoundItem).BoligID);
            BoligOplysninger boligOplysninger = new BoligOplysninger(bolig);

            this.Hide();
            boligOplysninger.ShowDialog();
            this.Show();

            if (boligOplysninger.DialogResult == DialogResult.OK)
            {
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

            SortDataTable(sender, e);
        }

        private void ExportListButton_MouseClick(object? sender, MouseEventArgs e)
        {
            // Create a SaveFileDialog to prompt the user for a file location
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                saveFileDialog.Title = "Gem sortering til fil";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    try
                    {
                        // Serialize the data to JSON
                        var options = new JsonSerializerOptions
                        {
                            WriteIndented = true,
                            Encoder = System.Text.Encodings.Web.JavaScriptEncoder.Create(System.Text.Unicode.UnicodeRanges.All)
                        };
                        string jsonString = JsonSerializer.Serialize(DataSorted, options);

                        // Write the JSON string to the file
                        File.WriteAllText(filePath, jsonString);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Filen kunne ikke gemmes: {ex.Message}", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
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

        private void homeSaleButton_Click(object sender, EventArgs e)
        {
            BoligRepository boligRepository = new BoligRepository();
            Bolig bolig = boligRepository.HentBolig(((BoligMedSælger)HomesGridView.SelectedRows[0].DataBoundItem).BoligID);
            salgBolig salgBolig = new salgBolig(bolig);
            this.Hide();
            salgBolig.ShowDialog();
            this.Show();

            if (salgBolig.DialogResult != DialogResult.OK)
            {
                return;
            }
            RefreshDataTable(sender, e);
        }
    }
    public class BoligSortValues
    {
        public String Address = "";
        public String Type = "";
        public String Area = "";
        public String Status = "";
        public int SizeMin = int.MinValue;
        public int SizeMax = int.MaxValue;
        public int PriceMin = int.MinValue;
        public int PriceMax = int.MaxValue;
        public int ShoppingDistanceMin = int.MinValue;
        public int ShoppingDistanceMax = int.MaxValue;
        public DateTime? SoldFromDate;
        public DateTime? SoldToDate;
    }
}
