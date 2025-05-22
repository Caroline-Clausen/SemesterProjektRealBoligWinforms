using Projekt1Semester;
using System.Windows.Forms;
namespace SemesterProjektRealBoligWinforms
{
    public static class Program
    {
        static Stack<Form> FormStack = new();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            // Configure application
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Create the initial form
            Form initialForm = new StartVindue();

            // Start application
            Application.Run(initialForm);
        }
    }
}
