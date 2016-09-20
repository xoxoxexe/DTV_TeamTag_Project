using Backend.Contracts;
using Backend.Impl;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class FinanzverwaltungController : Controller
    {
        // GET: Finanzverwaltung
        public ActionResult Index()
        {
            // Rechnungen holen
            IFinanzenFacade finanzenFacade = new FinanzenFacade();
            Finanzen finanzen = new Finanzen();
            finanzen.Rechnungen = finanzenFacade.GetFinanzUebersicht();
            finanzen.AktuellerSaldo = finanzen.Rechnungen.Sum( x => x.Preis );
            finanzen.Rechnungen=finanzen.Rechnungen.OrderByDescending( x => x.Datum );
            return View( finanzen );
        }
    }
}