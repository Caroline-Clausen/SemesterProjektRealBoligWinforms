using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1Semester
{
   public class Administrator : Person // arver fra Person
    {
        public int AdministratorID { get; set; } //Primarnøgle tildelt fra database (autogenereret)
        public string PersonNavn { get; set; } //Personens navn
        public string PersonEmail { get; set; } //Personens email
        public string PersonTelefon { get; set; } //Personens telefonnummer


        // login funktionen til administrator
        public string AdministratorBrugernavn { get; set; } //Brugernavn
        public string AdministratorPassword { get; set; } //Password
       
       
        
        // en metode hvor Administrator får mulighed for at ændre sit password
        public void ÆndreAdminPassword(string nyPassword)
        {
            AdministratorPassword = nyPassword;
        }
       

        // en metode hvor Administrator får mulighed for at ændre sit brugernavn
        public void ÆndreAdminBrugernavn(string nyBrugernavn)
        {
            AdministratorBrugernavn = nyBrugernavn;
        }
        

    }
}
