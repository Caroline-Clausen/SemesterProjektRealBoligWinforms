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
        }

        // hvis vi synes det er nødvendigt at have flere felter til bolig, kan vi tilføje dem her
        //public double BoligSolgtPris { get; set; } //salgspris på boligen
        //public double BoligNyPris { get; set; } //ny pris på boligen
        //public int BoligGrundAreal { get; set; }
        //public int BoligAntalEtager { get; set; }
        //public int BoligAntalKældre { get; set; }
        //public int BoligEtageLejlighed { get; set; }


        //_____________________________________________________

        // en metode til ændring af boligpris
        //public void ÆndreBoligPris(double nyPris)
        //{
        //    BoligNyPris = nyPris;
        //}
        //// en metode til at se hvor meget boligen er faldet i pris i %
        //public double BeregnBoligFaldIProcent()
        //{
        //    if (BoligNyPris == 0)
        //    {
        //        return 0;
        //    }
        //    else
        //    {
        //        double fald = ((BoligStartPris - BoligNyPris) / BoligStartPris) * 100;
        //        return fald;
        //    }
        //}

    }

}
