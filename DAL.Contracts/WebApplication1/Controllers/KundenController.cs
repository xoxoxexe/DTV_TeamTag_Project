using Backend.Contracts;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Backend.Impl;

namespace WebApplication1.Controllers
{
    public class KundenController : Controller
    {
        // GET: Kunden
        public ActionResult Index()
        {
            // Kundenliste aus dem Backend holen
            //IKundenFacade kundenFacade = ;
            //IEnumerable<Kunde> kunden = kundenFacade.GetKunden();
            IEnumerable<Kunde> kunden = new Collection<Kunde>
            {
                new Kunde {
                    Id = new Guid(),
                    Email = "ask@me.com",
                    Strasse = "Flurstraße 12",
                    Name = "Peter Pan",
                    Ort = "Nürnberg",
                    Plz = "90409",
                    Telefon = "0911-1231438"
                },
            };

            //IKundenFacade kundenFacade = new KundenFacade();
            //kunden = kundenFacade.GetKunden();

            return View( kunden );
        }

        // GET: Kunden/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Kunden/Create
        [HttpPost]
        public ActionResult Create( Kunde kunde )
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction( "Index" );
            }
            catch
            {
                return View();
            }
        }

        // GET: Kunden/Edit/5
        public ActionResult Edit( Guid id )
        {
            // Kunden-Datensatz anhand der ID aus dem Backend holen

            Kunde kunde = new Kunde
            {
                Id = new Guid(),
                Email = "ask@me.com",
                Strasse = "Flurstraße 12",
                Name = "Peter Pan",
                Ort = "Nürnberg",
                Plz = "90409",
                Telefon = "0911-1231438"
            };
            return View( kunde );
        }

        // POST: Kunden/Edit/5
        [HttpPost]
        public ActionResult Edit( Guid id, Kunde kunde )
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction( "Index" );
            }
            catch
            {
                return View();
            }
        }
    }
}