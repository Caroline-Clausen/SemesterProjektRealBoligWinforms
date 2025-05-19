using BusinessLayer;
using Model.RealBolig;
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
            Form initialForm = new Form1();

            // Add it o the FormStack manually.
            // If we used PushForm, it would connect the forms FormClosing event to PopForm.
            // This would cause PopForm to look for a parent form that doesn't exist and give an error.
            FormStack.Push(initialForm);

            // Start application
            Application.Run(initialForm);
        }

        /// <summary>
        /// Call to hide the active form and show a new form.
        /// When the form is closed, the old form will be shown again automatically.
        /// </summary>
        public static void PushForm(Form form)
        {
            // Hide old form
            FormStack.Peek().Hide();
            // Show new form
            form.Show();
            // Add callback to FormClosing, so that we can show the old form when the new form closes.
            form.FormClosing += PopForm;
            // Add new form to the FormStack
            FormStack.Push(form);
        }

        /// <summary>
        /// Called by a pushed form, when it is closing.
        /// </summary>
        private static void PopForm(object? sender, FormClosingEventArgs e)
        {
            // Remove old form from stack
            FormStack.Pop();

            // Show next form in the stack
            if (FormStack.Count != 0)
                FormStack.Peek().Show();
        }
    }
}
