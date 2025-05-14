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
        public RealtorForm()
        {
            InitializeComponent();
        }

        private void RealtorForm_Load(object sender, EventArgs e)
        {
            HomesGridView.DataSource = DBConnection.GetHomesTable();
            HomesGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
        }
    }
}
