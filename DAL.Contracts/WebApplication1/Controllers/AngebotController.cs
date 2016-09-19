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

namespace WebApplication1.Controllers
{
      public class AngebotController : Controller
    {
        public AngebotController()
        {
        }

       public ActionResult List()
        {
            //IAngebotFacade angebotsFacade;
            //List<Angebot> angebote = angebotsFacade.
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create( Angebot angebot )
        {
            return View();
        }

    }
}