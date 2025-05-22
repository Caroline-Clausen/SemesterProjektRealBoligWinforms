using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1Semester
{
    public class BoligUdvidet : Bolig
    {
        public required Saelger Sælger { get; set; }
        public required Ejendomsmaegler Mægler { get; set; }
    }
}
