using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Contracts
{
    public class FinanzenPosition
    {
        public DateTime Datum { get; set; }
        public string Monat { get; set; }
        public int Tag { get; set; }
        public string BelegNummer { get; set; }
        public decimal Preis { get; set; }
        public string Name { get; set; }
    }
}
