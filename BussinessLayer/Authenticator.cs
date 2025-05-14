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
            // Try to get realtor from database with matching username
            Ejendomsmaegler? realtor = DBConnection.GetRealtor(username);

            // Ensure we could got a realtor
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
