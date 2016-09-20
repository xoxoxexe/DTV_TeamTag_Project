using System;
using System.Collections.Generic;
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
            using (var context = new teamtageEntities())
            {
                foreach(Kunden kunde in context.Kunden)
                {
                    listKunde.Add(new Kunde() { Email = kunde.Email, Id = kunde.ID, Name = kunde.Name, Ort = kunde.Ort, Plz = kunde.Plz, Strasse = kunde.Strasse, Telefon = kunde.Tel });
                }                
            }

            return listKunde;            
        }

        void IKundenFacade.Save(Kunde kunde)
        {
            using (var context = new teamtageEntities())
            {
                context.Kunden.Add(new Kunden() { Email = kunde.Email, Name = kunde.Name, Ort = kunde.Ort, Plz = kunde.Plz, Strasse = kunde.Strasse, Tel = kunde.Telefon });
                context.SaveChanges();
            }
        }
    }
}
