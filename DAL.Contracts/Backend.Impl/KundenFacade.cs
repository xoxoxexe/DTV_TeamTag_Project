using System;
using System.Collections.Generic;
using Backend.Contracts;
using DAL.Impl;

namespace Backend.Impl
{
    public class KundenFacade : IKundenFacade
    {
        IEnumerable<Kunde> IKundenFacade.GetKunden()
        {
            //return new List<Kunde>()
            //{
            //    new Kunde() {Email = "teamdatev@datev.de", Name = "DatevTEam", Ort = "Nürnberg", Plz = "91522", Telefon = "0911/18383", Strasse = "PaumgartnerStraße"},
            //    new Kunde() {Email = "teasdasdastev@datev.de", Name = "DatevTEdasdasdasdasdasam", Ort = "Nürnberg", Plz = "91522", Telefon = "0911/18383", Strasse = "PaumgartnerStraße"},
            //    new Kunde() {Email = "teamdatev@datev.de", Name = "DatevTEam", Ort = "Nürnberg", Plz = "91522", Telefon = "0911/18383", Strasse = "PaumgartnerStraße"},
            //};

            List<Kunde> listKunde = new List<Kunde>();
            using (var context = new teamtageEntities1())
            {
                foreach (Kunden kunde in context.Kunden)
                {
                    listKunde.Add(new Kunde()
                    {
                        Email = kunde.Email,
                        Id = kunde.ID,
                        Name = kunde.Name,
                        Ort = kunde.Ort,
                        Plz = kunde.Plz,
                        Strasse = kunde.Strasse,
                        Telefon = kunde.Tel
                    });
                }
            }

            return listKunde;
        }

        public Kunde GetKunde(Guid guid)
        {
            //return new Kunde()
            //{
            //    Email = "teamdatev@datev.de",
            //    Name = "DatevTEam",
            //    Ort = "Nürnberg",
            //    Plz = "91522",
            //    Telefon = "0911/18383",
            //    Strasse = "PaumgartnerStraße"
            //};

            Kunde mappedKunde;
            using (var context = new teamtageEntities1())
            {
                Kunden kunde = context.Kunden.Find(guid);

                mappedKunde = new Kunde()
                {
                    Email = kunde.Email,
                    Id = kunde.ID,
                    Name = kunde.Name,
                    Ort = kunde.Ort,
                    Plz = kunde.Plz,
                    Strasse = kunde.Strasse,
                    Telefon = kunde.Tel
                };
            }
            return mappedKunde;
        }

        void IKundenFacade.Save(Kunde kunde)
        {
            using (var context = new teamtageEntities1())
            {
                Kunden foundKunde = context.Kunden.Find(kunde.Id);
                if (foundKunde != null)
                {
                    foundKunde.Email = kunde.Email;
                    foundKunde.ID = kunde.Id;
                    foundKunde.Name = kunde.Name;
                    foundKunde.Ort = kunde.Ort;
                    foundKunde.Strasse = kunde.Strasse;
                    foundKunde.Plz = kunde.Plz;
                    foundKunde.Tel = kunde.Telefon;
                }
                else
                {
                    Kunden neuerKunde = new Kunden()
                    {
                        Email = kunde.Email,
                        ID = Guid.NewGuid(),
                        Name = kunde.Name,
                        Ort = kunde.Ort,
                        Strasse = kunde.Strasse,
                        Plz = kunde.Plz,
                        Tel = kunde.Telefon 
                    };

                    context.Kunden.Add(neuerKunde);
                }

                context.SaveChanges();

            }
        }
    }
}