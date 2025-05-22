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

        // login funktionen til administrator
        public string? AdministratorBrugernavn { get; set; } //Brugernavn
        public string? AdministratorPassword { get; set; } //Password
    }
}
