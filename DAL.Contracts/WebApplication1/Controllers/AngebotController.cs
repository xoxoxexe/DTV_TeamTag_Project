﻿using System;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using WebApplication1.Models;
using Backend.Contracts;
using System.Collections.Generic;
using Backend.Impl;

namespace WebApplication1.Controllers
{
      public class AngebotController : Controller
    {
        public AngebotController()
        {
        }

       public ActionResult List()
        {
            //IAngebotFacade angebotFacade;
            List<Angebot> angebote;

            IAngebotFacade angebotFacade = new AngebotFacade();

            //IAngebotFacade angebotFacade = new AngebotFacade();

            //angebote = angebotFacade.GetAngebote().ToList();


            return View( angebote );
        }

        public ActionResult Create()
        {
            // Alle Kunden
            LoadKunden();
            return View();
        }

        [HttpPost]
        public ActionResult Create( Angebot angebot )
        {
            IAngebotFacade angebotFacade = new AngebotFacade();
            angebotFacade.Save(angebot);
            LoadKunden();
            return View();
        }


        private void LoadKunden()
        {
            IKundenFacade kundenFacade = new KundenFacade();
            IEnumerable<Kunde> alleKunden = kundenFacade.GetKunden();
            ViewBag.AlleKunden = alleKunden;
        }
    }
}