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
            // Det her skal pege på den form du vil starte med:
            Application.Run(new Form1());
        }
    }
}
