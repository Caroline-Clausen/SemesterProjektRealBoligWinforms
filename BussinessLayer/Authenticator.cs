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
        public static Ejendomsmaegler? LoginRealtor(string username, string password)
        {
            Ejendomsmaegler? realtor = DBConnection.GetRealtor(username);

            if (realtor == null)
            {
                return null;
            }

            // Check passowrd is correct
            if (realtor.EjendomsmaeglerPassword == password)
            {
                return realtor;
            }

            return null;
        }
    }
}
