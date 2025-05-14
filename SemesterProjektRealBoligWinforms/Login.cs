using BusinessLayer;
using DataAccess;
using Projekt1Semester;

namespace SemesterProjektRealBoligWinforms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void IncorrectValuesPopup()
        {
            MessageBox.Show(
                "Det indtastede brugernavn eller kodeord er forkert.",
                "Fokrert brugernavn eller kodeord",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
        }

        private bool ValidateInput(String username, String password)
        {
            // Ensure both strings are not empty
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                // Show error box to user
                MessageBox.Show(
                  "Indtast både brugernavn og adgangskode.",
                  "Manglende input",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Warning
                );
                return false;
            }
            return true;
        }

        private void godkendAdminKnap_Click(object sender, EventArgs e)
        {
            // 1) Hent input
            string user = adminBrugernavnTekstbox.Text.Trim();
            string pass = adminPasswordTekstbox.Text.Trim();

            // 2) Simpel UI-validering
            if (!ValidateInput(user, pass))
            {
                return;
            }

            // 3) Kald databasen via Repository
            var repo = new AdministratorRepository();
            bool succes = repo.Authenticate(user, pass);

            // 4) Håndter login-resultatet
            if (succes)
            {
                // Hvis login OK, åbn næste form
                OpretMægler opretMægler = new();
                Program.PushForm(opretMægler);
            } else
            {
                IncorrectValuesPopup();
            }
        }

        private void ejendomsmæglerGodkendKanp_MouseClick(object sender, MouseEventArgs e)
        {
            // Retrieve username and password from textboxes
            String username = ejendomsmæglerBrugernavnTekstbox.Text;
            String password = EjendomsmæglerPasswordTekstbox.Text;

            if (!ValidateInput(username, password))
            {
                return;
            }

            // Try to authenticate with provided login
            Ejendomsmaegler? account;
            try
            {
                account = Authenticator.LoginRealtor(username, password);
            } catch (Exception ex)
            {
                // Exception doesn't occur if the password or username was incorect
                // Most likely an error occurs if there was a problem connecting with the database
                MessageBox.Show(ex.Message);
                return;
            }

            // If we get a null value, we know authentication failed.
            if (account == null)
            {
                IncorrectValuesPopup();
                return;
            }

            // Show realtor page
            RealtorForm form = new();
            Program.PushForm(form);
        }
    }
}
