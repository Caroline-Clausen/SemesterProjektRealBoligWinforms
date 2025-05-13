using DataAccess;
using Projekt1Semester;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public static class Authenticator
    {
        public static Administrator? LoginAdmin(string username, string password)
        {
            // Connect to database
            using (DBConnection conn = new())
            {

            }

            return null;
        }
    }
}
