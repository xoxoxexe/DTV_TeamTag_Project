using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Contracts
{
    public class AusgangsRechnung
    {
        public DateTime Datum { get; set; }
        public string Nummer { get; set; }
        public decimal Preis { get; set; }

        public string KundenName { get; set; }
    }
}
