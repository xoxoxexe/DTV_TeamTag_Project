using System;
using System.Collections.Generic;
using AutoMapper;
using Backend.Contracts;
using DAL.Impl;

namespace Backend.Impl
{
    public class AngebotFacade : IAngebotFacade
    {
        IEnumerable<Angebot> IAngebotFacade.GetAngebote()
        {


            //return new List<Angebot>()
            //{
            //    new Angebot() {AngebotsNummer = 1, Betreff = "SUper Betreff", Datum =  DateTime.Now, Gesamt =  1000, Positionen = new List<Position>() {new Position() {Freitext = "Hier ist freier Text", Preis = 1000} } },
            //    new Angebot() {AngebotsNummer = 2, Betreff = "Subber Bedreff", Datum =  DateTime.Now, Gesamt =  1000, Positionen = new List<Position>() {new Position() {Freitext = "Hier ist freier Text", Preis = 1000} } },
            //    new Angebot() {AngebotsNummer = 3, Betreff = "Super Betreff", Datum =  DateTime.Now, Gesamt =  1000, Positionen = new List<Position>() {new Position() {Freitext = "Hier ist freier Text", Preis = 1000} } }
            //};

            List<Angebot> allAngebote = new List<Angebot>();
            using (var context = new teamtageEntities1())
            {
                //var mapper = config.CreateMapper();

                foreach (Angebote angebot in context.Angebote)
                {
                    allAngebote.Add(new Angebot() { Betreff = angebot.Betreff, Datum = angebot.Datum, Id = angebot.ID, KundeId = angebot.KundeID, Positionen = MapDalAngebotsPositionenToBackend(angebot.Angebotspositionen), Gesamt = GetAngebotGesamtpreis(angebot.Angebotspositionen) });
                    //allAngebote.Add(mapper.Map(angebot, new Angebot()));

                    //Angebot mappedAngebot = mapper.Map<Angebot>(angebot);
                    //allAngebote.Add(mappedAngebot);
                }
            }
            return allAngebote;
        }

        void IAngebotFacade.Save(Angebot angebot)
        {
            using (var context = new teamtageEntities1())
            {
                context.Angebote.Add(new Angebote() {Angebosnummer = angebot.AngebotsNummer ,Angebotspositionen = MapBackendAngebotsPositionenToDal(angebot.Positionen), Betreff = angebot.Betreff, Datum = angebot.Datum, KundeID = angebot.KundeId });
                context.SaveChanges();
            }
        }

        private ICollection<Position> MapDalAngebotsPositionenToBackend(ICollection<Angebotspositionen> angebotsPositionen)
        {
            List<Position> mappedBackendPositionen = new List<Position>();
            if (angebotsPositionen == null)
            {
                return mappedBackendPositionen;
            }
            
            foreach (Angebotspositionen positionen in angebotsPositionen)
            {
                mappedBackendPositionen.Add(new Position { Freitext = positionen.Freitext, Preis = (double)positionen.Reis });
            }
            return mappedBackendPositionen;
        }

        public static ICollection<Angebotspositionen> MapBackendAngebotsPositionenToDal(IEnumerable<Position> angebotsPositionen)
        {
            List<Angebotspositionen> mappedDalPositionen = new List<Angebotspositionen>();

            if (angebotsPositionen == null)
                return mappedDalPositionen;

            
            foreach (Position positionen in angebotsPositionen)
            {
                mappedDalPositionen.Add(new Angebotspositionen { Freitext = positionen.Freitext, Reis = (decimal)positionen.Preis });
            }
            return mappedDalPositionen;
        }

        public static double GetAngebotGesamtpreis(ICollection<Angebotspositionen> angebotsPositionen)
        {
            double sum = 0;
            foreach (Angebotspositionen position in angebotsPositionen)
            {
                sum += (double)position.Reis;
            }
            return sum;
        }
    }
}
