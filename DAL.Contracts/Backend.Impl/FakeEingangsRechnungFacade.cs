using Backend.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Impl
{
    public class FakeEingangsRechnungFacade : IEingangsRechnungFacade
    {
        public IEnumerable<EingangsRechnung> GetEingangsRechnungen()
        {
            return new List<EingangsRechnung> {
               new EingangsRechnung {
                    Datum = new DateTime(2016,9,1),
                    LieferantName = "Döner um die Ecke",
                    Nummer = "2",                
                    Preis = 100
               },
               new EingangsRechnung {
                    Datum = new DateTime(2016,8,2),
                    LieferantName = "Portal Entwiclungskosten",
                    Nummer = "1",
                    Preis = 50000
               }
           };
        }
    }
}
