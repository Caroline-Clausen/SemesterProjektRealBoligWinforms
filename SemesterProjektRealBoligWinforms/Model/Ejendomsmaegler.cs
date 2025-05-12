using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1Semester
{
    public class Ejendomsmaegler : Person
    {
        public int EjendomsmaeglerID { get; set; } //Primarnøgle tildelt fra database (autogenereret)
        public string EjendomsmaeglerBrugernavn { get; set; } //Brugernavn
        public string EjendomsmaeglerPassword { get; set; } //Password
       
        
        // arver fra Person

        //En metode hvor Administrator opretter en ny Ejendomsmaegler
        public Ejendomsmaegler(string brugernavn, string password, string navn, string email, string telefon)
        {
            EjendomsmaeglerBrugernavn = brugernavn;
            EjendomsmaeglerPassword = password;
            PersonNavn = navn;
            PersonEmail = email;
            PersonTelefon = telefon;
        }
        // en metode hvor Administrator får mulighed for at ændre password på Ejendomsmaegler
        public void ÆndrePassword(string nyPassword)
        {
            EjendomsmaeglerPassword = nyPassword;
        }
        // en metode hvor Administrator får mulighed for at ændre brugernavn på Ejendomsmaegler
        public void ÆndreBrugernavn(string nyBrugernavn)
        {
            EjendomsmaeglerBrugernavn = nyBrugernavn;
        }
        // en metode hvor Administrator får mulighed for at ændre navn på Ejendomsmaegler
        public void ÆndreNavn(string nyNavn)
        {
            PersonNavn = nyNavn;
        }
    }
}
