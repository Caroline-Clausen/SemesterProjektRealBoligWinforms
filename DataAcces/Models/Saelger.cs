using System;
using Projekt1Semester;


namespace Projekt1Semester { }
public class Saelger : Person
{
    public int SaelgerID { get; set; } //Primarnøgle tildelt fra database (autogenereret)

    public Saelger()
    {
        SaelgerID = 0;
    }
}
