using System;
using System.Collections.Generic;

namespace Backend.Contracts
{
    public class Angebot
    {
        public int Id { get; set; }

        public int KundeId { get; set; }

        public IEnumerable<Position> Positionen { get; set; }

        public double Gesamt { get; set; }

        public DateTime Datum { get; set; }
    }
}
