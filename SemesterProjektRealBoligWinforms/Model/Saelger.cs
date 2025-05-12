using System;
using Projekt1Semester;


namespace Projekt1Semester { }
internal class Saelger : Person
{
    public int SaelgerID { get; set; } //Primarnøgle tildelt fra database (autogenereret)

    public Saelger(string navn, string email, string telefon)
    {
        PersonNavn = navn;
        PersonEmail = email;
        PersonTelefon = telefon;
    }
}
