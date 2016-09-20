using System;
using System.Collections.Generic;
using Backend.Contracts;
using DAL.Impl;
using System.Linq;
namespace Backend.Impl
{
    public class AngebotFacade : IAngebotFacade
    {
        IEnumerable<Angebot> IAngebotFacade.GetAngebote()
        {
            List<Angebot> allAngebote = new List<Angebot>();
            using (var context = new teamtageEntities())
            {
                foreach(DAL.Impl.Angebote angebot in context.Angebote)
                {
                    allAngebote.Add(new Backend.Contracts.Angebot() {AngebotsNummer = angebot.Angebotsnummer ,Betreff = angebot.Betreff, Datum = angebot.Datum, Id = angebot.ID, KundeId = angebot.KundeID, Positionen = MapDalAngebotsPositionenToBackend(angebot.Angebotspositionen), Gesamt= GetAngebotGesamtpreis(angebot.Angebotspositionen) });
                }
            }
            return allAngebote;
        }

        void IAngebotFacade.Save(Backend.Contracts.Angebot angebot)
        {

            using(var context = new teamtageEntities())
            {
                context.Angebote.Add(new DAL.Impl.Angebote() { Angebotsnummer = angebot.Id.ToString(), Angebotspositionen = MapBackendAngebotsPositionenToDal(angebot.Positionen), Betreff = angebot.Betreff, Datum = angebot.Datum, KundeID = angebot.KundeId, ID = angebot.Id });
            }
        }

        private ICollection<Backend.Contracts.Position> MapDalAngebotsPositionenToBackend(ICollection<DAL.Impl.Angebotspositionen> angebotsPositionen) {
            List<Backend.Contracts.Position> mappedBackendPositionen = new List<Position>();
            foreach(Angebotspositionen positionen in angebotsPositionen)
            {
                mappedBackendPositionen.Add(new Position() { Freitext = positionen.Freitext, Preis = (double)positionen.Reis });
            }
            return mappedBackendPositionen;
        }

        private ICollection<DAL.Impl.Angebotspositionen> MapBackendAngebotsPositionenToDal(IEnumerable<Backend.Contracts.Position> angebotsPositionen)
        {
            List<DAL.Impl.Angebotspositionen> mappedDalPositionen = new List<Angebotspositionen>();
            foreach (Position positionen in angebotsPositionen)
            {
                mappedDalPositionen.Add(new Angebotspositionen() { Freitext = positionen.Freitext, Reis= (decimal)positionen.Preis });
            }
            return mappedDalPositionen;
        }

        private double GetAngebotGesamtpreis (ICollection<DAL.Impl.Angebotspositionen> angebotsPositionen)
        {
            double sum = 0;
            foreach(Angebotspositionen position in angebotsPositionen)
            {
                sum += (double)position.Reis;
            }

            return sum;
        }
    }
}
