using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BrojGodina.Controllers
{
    public class NarudzbaArtiklaController : Controller
    {
        // GET: NarudzbaArtikla
        public ActionResult NaruciArtikl()
        {
            return View(new Artikal());
        }
        //post
        [HttpPost]
        public ActionResult NaruciArtikl(Artikal artikal)
        {
            if (artikal.Kolicina >10)
            {
                ViewBag.Poruka = "Nema dovoljno " + artikal.Naziv + " na skladištu.";
                return View(artikal);
            }
            else
            {
                ViewBag.Poruka = "Naručeno je " + artikal.Kolicina + " komada " +
                    artikal.Naziv + " sa ukupnom cijenom " + artikal.Cijena * artikal.Kolicina;
                return View(artikal);
            }
        }

    }
}