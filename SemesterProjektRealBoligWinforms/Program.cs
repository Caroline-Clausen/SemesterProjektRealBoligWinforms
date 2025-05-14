using BusinessLayer;
using Model.RealBolig;
using Projekt1Semester;
using System.Windows.Forms;
namespace SemesterProjektRealBoligWinforms
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            List<Bolig> boliger = new List<Bolig>();
            List<Ejendomsmaegler> ejendomsmaeglere = new List<Ejendomsmaegler>();
            List<Administrator> administratorer = new List<Administrator>();
            List<Person> personer = new List<Person>();
            List<Saelger> saelgere = new List<Saelger>();
            List<Koeber> koebere = new List<Koeber>();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Det her skal pege på den form du vil starte med:
            Application.Run(new Form1());

        }


    }



}
