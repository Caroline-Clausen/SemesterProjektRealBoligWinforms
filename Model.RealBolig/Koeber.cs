using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1Semester
{
    internal class Koeber : Person
    {
        public int KoeberID { get; set; } //Primarnøgle tildelt fra database (autogenereret)

        //arver fra Person
        //public string PersonNavn { get; set; } //Personens navn

        public Koeber(string navn, string email, string telefon, string rolle)
        {
            PersonNavn = navn;
            PersonEmail = email;
            PersonTelefon = telefon;
        }
    }
}
