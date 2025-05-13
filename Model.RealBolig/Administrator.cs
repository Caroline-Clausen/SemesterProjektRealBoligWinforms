using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1Semester
{
    internal class Administrator : Person
    {
        public int AdministratorID { get; set; } //Primarnøgle tildelt fra database (autogenereret)
        // login funktionen til administrator
        public string AdministratorBrugernavn { get; set; } //Brugernavn
        public string AdministratorPassword { get; set; } //Password
       
        //Administratorens navn
        public string AdministratorNavn { get; set; } //Navn

        // en metode hvor Administrator får mulighed for at ændre sin password
        public void ÆndrePassword(string nyPassword)
        {
            AdministratorPassword = nyPassword;
        }
        // en metode hvor Administrator får mulighed for at ændre sin brugernavn
        public void ÆndreBrugernavn(string nyBrugernavn)
        {
            AdministratorBrugernavn = nyBrugernavn;
        }
        // en metode hvor Administrator får mulighed for at ændre sin navn
        public void ÆndreNavn(string nyNavn)
        {
            AdministratorNavn = nyNavn;
        }

    }
}
// tilføj person funktioner til administrator