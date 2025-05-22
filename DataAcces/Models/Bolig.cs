using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1Semester
{
    public class Bolig
    {
        //tilføjelse af bolig
        public int BoligID { get; set; } //Primarnøgle tildelt fra database (autogenereret)
        public string Adresse { get; set; }  //boligens adresse
        public double Kvadratmeter { get; set; } //boligens areal i m2
        public string Type { get; set; } //boligtype
        public double Pris { get; set; } //boligens pris
        public double AfstandTilIndkoeb { get; set; } //afstand til indkøb
        public string Status { get; set; } //boligens status (til salg, solgt, annulleret)
        public int? SaelgerID { get; set; } // fra saelgerID (nullable)
        public string Område { get; set; } //område fx Bredballe. Skal med er sprøgsmål i problemformuleringen
      
        public Bolig()
        {
            BoligID = 0;
            Status = "til salg";
            Adresse = "";
            Type = "";
            Område = "";
        }
    }
}
