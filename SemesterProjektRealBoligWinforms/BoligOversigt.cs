using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;

namespace SemesterProjektRealBoligWinforms
{
    public partial class BoligOversigtKunde : Form
    {
        public BoligOversigtKunde()
        {
            InitializeComponent();
        }

        private void boligKundeGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         //DBConnection dbConnection = new DBConnection();
           DBConnection.GetHomesTable();

        }
    }
}
