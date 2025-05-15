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
using static System.Windows.Forms.DataFormats;



namespace SemesterProjektRealBoligWinforms
{
    public partial class OpretBolig : Form
    {
        public Ejendomsmaegler realtor;
        public OpretBolig(Ejendomsmaegler realtor)
        {
            InitializeComponent();
            this.realtor = realtor;

        }

        public void OpretBolig_Load(object sender, EventArgs e)
        {

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void buttonBolig_Click(object sender, EventArgs e)
        {
            //Tanken var at, hvis man trykkede på knappen for at tilføje en bolig, så åbner sig en ny winform vindue hvor du tilføjer
            //alle de relevante informationer for boligen bliver tilføjet til en tabel hvor den nye bolig bliver oprettet, med fremtidig mulighed for at slette boligen igen

            OpretBolig f2 = new OpretBolig();
            f2.ShowDialog(); // Viser tilføj Bolig form

        }
    }
}
