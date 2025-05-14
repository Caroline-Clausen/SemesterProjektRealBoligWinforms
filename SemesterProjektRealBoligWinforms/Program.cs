using BusinessLayer;
using Model.RealBolig;
using Projekt1Semester;
using System.Windows.Forms;
namespace SemesterProjektRealBoligWinforms
{
    public static class Program
    {
        static Form EntryForm = new Form1();
        static Stack<Form> FormStack = new();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Run application with the entry form
            FormStack.Push(EntryForm);
            Application.Run(EntryForm);
        }

        /// <summary>
        /// Call to hide the active form and show a new form.
        /// When the form is closed, the old form will be shown again automatically.
        /// </summary>
        public static void PushForm(Form form)
        {
            // Hide current form
            FormStack.Peek().Hide();
            // Show new form
            form.Show();
            // Add callback to FormClosing, so that we can show the old form again.
            form.FormClosing += PopForm;
            // Add new form to FormStack
            FormStack.Push(form);
        }

        /// <summary>
        /// Called by a pushed form, when it is closing.
        /// </summary>
        private static void PopForm(object? sender, FormClosingEventArgs e)
        {
            // Remove form from stack
            FormStack.Pop();
            // Show old form
            FormStack.Peek().Show();
        }
    }
}
