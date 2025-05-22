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
        public string? EjendomsmaeglerBrugernavn { get; set; } //Brugernavn
        public string? EjendomsmaeglerPassword { get; set; } //Password
    }
}
