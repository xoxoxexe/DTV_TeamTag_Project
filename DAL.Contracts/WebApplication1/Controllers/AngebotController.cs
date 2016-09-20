using System;
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
            List<Angebot> angebote;
            IAngebotFacade angebotFacade = new AngebotFacade();   
            angebote = angebotFacade.GetAngebote().ToList();
            return View( "List", angebote );
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

        [HttpPost]
        public ActionResult CreateWithPdf(Angebot angebot)
        {
            IAngebotFacade angebotFacade = new AngebotFacade();
            angebotFacade.Save(angebot);
            String url2pdf = Pdf.Create( angebot );
            return RedirectToAction(url2pdf);
        }

        [HttpPost]
        public ActionResult CreateWithMail(Angebot angebot)
        {
            IAngebotFacade angebotFacade = new AngebotFacade();
            angebotFacade.Save(angebot);
            Mail.SEnd();           
            return RedirectToAction("MailAction");
        }

        public ActionResult PdfAction()
        {
            return View();
        }

        public ActionResult MailAction()
        {
            return View();
        }


        private void LoadKunden()
        {
            IKundenFacade kundenFacade = new KundenFacade();
            IEnumerable<Kunde> alleKunden = kundenFacade.GetKunden();
            ViewBag.AlleKunden = alleKunden;
        }

        public ActionResult RechnungErzeugen(String  angebotId)
        {

            IAngebotFacade angebotFacade = new AngebotFacade();

            angebotFacade.CreateBill(new Angebot
            {
                Id = Guid.Parse(angebotId)
            });

            return List();
        }

    }


    public static class Pdf
    {
        public static string Create( Angebot angebot)
        {
            return "PdfAction";       
        }
    }

    public static class Mail
    {
        public static void SEnd()
        {
        }
    }
}