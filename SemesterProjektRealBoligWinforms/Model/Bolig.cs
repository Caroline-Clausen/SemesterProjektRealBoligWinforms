using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1Semester
{
    internal class Bolig
    {
        //tilføjelse af bolig
        public int BoligID { get; set; } //Primarnøgle tildelt fra database (autogenereret)
        public string BoligAdresse { get; set; }  //boligens adresse
        public double BoligAreal { get; set; } //boligens areal i m2
        public string BoligType { get; set; } //boligtype
        public double BoligStartPris { get; set; } //boligens pris
        public double BoligAfstandTilIndkoeb { get; set; } //afstand til indkøb
        public string BoligOmråde { get; set; } //område fx Bredballe. Skal med er sprøgsmål i problemformuleringen
        public double BoligNyPris { get; set; } //ny pris på boligen
        public double BoligSolgtPris { get; set; } //salgspris på boligen
        public string BoligStatus { get; set; } //boligens status (til salg, solgt, annulleret)

        // hvis vi synes det er nødvendigt at have flere felter til bolig, kan vi tilføje dem her
        //public int BoligGrundAreal { get; set; }
        //public int BoligAntalEtager { get; set; }
        //public int BoligAntalKældre { get; set; }
        //public int BoligEtageLejlighed { get; set; }


        //_____________________________________________________

        // en metode til ændring af boligpris
        public void ÆndreBoligPris(double nyPris)
        {
            BoligNyPris = nyPris;
        }
        // en metode til at se hvor meget boligen er faldet i pris i %
        public double BeregnBoligFaldIProcent()
        {
            if (BoligNyPris == 0)
            {
                return 0;
            }
            else
            {
                double fald = ((BoligStartPris - BoligNyPris) / BoligStartPris) * 100;
                return fald;
            }
        }

    }

}
