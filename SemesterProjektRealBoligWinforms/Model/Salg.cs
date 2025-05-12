using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1Semester
{
   public class Salg

    {
        public int SalgID { get; set; } //Primarnøgle tildelt fra database (autogenereret)
        public int BoligID { get; set; } //EjendomID
        public int SaelgerID { get; set; } //SælgerID
        public int EjendomsmaeglerID { get; set; } //EjendomsmaeglerID
        public int KoeberID { get; set; } //KøberID
        public DateTime Salgsdato { get; set; } //Salgsdato
        public double Salgspris { get; set; } //Salgspris
        public string SalgStatus { get; set; } //Salgstatus (til salg, solgt, annulleret)

    }
}
