using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Contracts
{
    public class EingangsRechnung
    {

        public DateTime Datum { get; set; }
        public string Nummer { get; set; }
        public double Preis { get; set; }

        public string LieferantName { get; set; }
    }
}
