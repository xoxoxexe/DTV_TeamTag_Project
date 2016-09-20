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
            IKundenFacade kundenFacade = new KundenFacade();
            IEnumerable<Kunde> kunden = kundenFacade.GetKunden();
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
                IKundenFacade kundenFacade = new KundenFacade();
                kundenFacade.Save(kunde);
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
            IKundenFacade kundenFacade = new KundenFacade();
            IEnumerable<Kunde> kunden = kundenFacade.GetKunden();
            Kunde kunde = kunden.SingleOrDefault( x => x.Id == id );
            return View( kunde );
        }

        // POST: Kunden/Edit/5
        [HttpPost]
        public ActionResult Edit( Guid id, Kunde kunde )
        {
            try
            {
                // TODO: Add update logic here

                IKundenFacade kundenFacade = new KundenFacade();
                kundenFacade.Save( kunde );
                return RedirectToAction( "Index" );
            }
            catch
            {
                return View();
            }
        }
    }
}