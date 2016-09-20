using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using Backend.Contracts;
using DAL.Impl;
using System.Linq;

namespace Backend.Impl
{
    public class KundenFacade : IKundenFacade
    {
        IEnumerable<Kunde> IKundenFacade.GetKunden()
        {
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
                foundKunde.Email = kunde.Email;
                foundKunde.ID = kunde.Id;
                foundKunde.Name = kunde.Name;
                foundKunde.Ort = kunde.Ort;
                foundKunde.Strasse = kunde.Strasse;
                foundKunde.Plz = kunde.Plz;
                foundKunde.Tel = kunde.Telefon;
                context.SaveChanges();
            }
        }
    }
}