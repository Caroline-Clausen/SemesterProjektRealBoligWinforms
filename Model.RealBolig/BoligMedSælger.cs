using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1Semester
{
    public class BoligMedSælger
    {
        //tilføjelse af bolig
        public int BoligID { get; set; } //Primarnøgle tildelt fra database (autogenereret)
        public string Adresse { get; set; }  //boligens adresse
        public double Kvadratmeter { get; set; } //boligens areal i m2
        public string Type { get; set; } //boligtype
        public double Pris { get; set; } //boligens pris
        public double AfstandTilIndkoeb { get; set; } //afstand til indkøb
        public string Status { get; set; } //boligens status (til salg, solgt, annulleret)
        public string Område { get; set; } //område fx Bredballe. Skal med er sprøgsmål i problemformuleringen
        public int? MæglerID { get; set; }
        public string? MæglerNavn { get; set; } //Egendomsmæglerens navn
        public string? MæglerMail { get; set; } //Egendomsmæglerens email
        public string? MæglerTelefon { get; set; } //Egendomsmæglerens telefonnummer
                
        public string? SælgerNavn { get; set; } //Sælgerens navn
        public string? SælgerMail { get; set; } //Sælgerens email
        public string? SælgerTelefon { get; set; } //Sælgerens telefonnummer
    }

}
