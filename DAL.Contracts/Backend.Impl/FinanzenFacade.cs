using Backend.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Impl
{
    public class FinanzenFacade : IFinanzenFacade
    {
        public IEnumerable<FinanzenPosition> GetFinanzUebersicht()
        {
            IAusgangsRechnungFacade arf = new AusgangsRechnungFacade();
            IEingangsRechnungFacade erf = new FakeEingangsRechnungFacade();

            List<FinanzenPosition> positionen = arf.GetAusgangsRechnungen().Select(r => new FinanzenPosition {
                BelegNummer = r.Nummer,
                Preis = r.Preis,
                Name = r.KundenName,
                Monat = r.Datum.ToString("MMM"),
                Tag = r.Datum.Day,
                Datum = r.Datum
            }).ToList();

            positionen.AddRange(erf.GetEingangsRechnungen().Select(r => new FinanzenPosition
            {
                BelegNummer = r.Nummer,
                Preis = r.Preis * -1,
                Name = r.LieferantName,
                Monat = r.Datum.ToString("MMM"),
                Tag = r.Datum.Day
            }));
            return positionen.OrderBy(r => r.Datum).ToList();
        }
    }
}
