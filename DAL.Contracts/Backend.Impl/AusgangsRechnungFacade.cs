using Backend.Contracts;
using DAL.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Impl
{
    public class AusgangsRechnungFacade : IAusgangsRechnungFacade
    {
        public IEnumerable<AusgangsRechnung> GetAusgangsRechnungen()
        {
            using (var context = new teamtageEntities1())
            {
                var rechnungen = context.Rechnungen.Select(r=>new AusgangsRechnung {
                    Datum = r.Erstellungsdatum.Value,
                    KundenName = r.Kunden.Name,
                    Nummer = r.Rechnungsnummer.ToString(),
                    Preis = r.Rechnungspositionen.Sum(rp=>rp.Preis)
                });
                return rechnungen.ToList();
   
            }
        }
    }
}
