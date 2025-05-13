using DataAccess;

namespace BusinessLayer
{
    public class AdministratorService
    {
        private readonly AdministratorRepository _repo = new();

        public bool Login(string brugernavn, string adgang)
        {
            // her kan du tilføje lockout, logging osv.
            return _repo.Authenticate(brugernavn, adgang);
        }
    }
}
