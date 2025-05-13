using BusinessLayer;
using Model.RealBolig;
using Projekt1Semester;
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
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            List<Bolig> boliger = new List<Bolig>();
            List<Ejendomsmaegler> ejendomsmaeglere = new List<Ejendomsmaegler>();
            List<Administrator> administratorer = new List<Administrator>();
            List<Person> personer = new List<Person>();
            List<Saelger> saelgere = new List<Saelger>();
            List<Koeber> koebere = new List<Koeber>();

        }


    }



}
