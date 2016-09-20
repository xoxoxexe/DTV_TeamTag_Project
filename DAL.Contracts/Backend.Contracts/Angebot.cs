using System;
using System.Collections.Generic;

namespace Backend.Contracts
{
    public class Angebot
    {
        public Guid Id { get; set; }

        public Guid KundeId { get; set; }

        public IEnumerable<Position> Positionen { get; set; }

        public double Gesamt { get; set; }

        public DateTime Datum { get; set; }

        public string Betreff { get; set; }

        public string AngebotsNummer { get; set; }
    }
}
