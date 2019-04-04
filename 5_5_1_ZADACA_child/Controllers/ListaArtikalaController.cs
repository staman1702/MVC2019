using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _5_5_1_ZADACA_child.Models;

namespace _5_5_1_ZADACA_child.Controllers
{
    public class ListaArtikalaController : Controller
    {
        // GET: ListaArtikala
        public ActionResult UnesiArtikl()
        {
            ViewBag.Kategorije = new String[] { "Čokolada", "Keks", "Bonbon" };
            return View(new Artikal());
        }

        [HttpPost]
        public ActionResult DodajArtikl(Artikal artikal)
        {
            if (Session["ListaArtikala"] !=null)
            {
                List<Artikal> listaArtikala = (List<Artikal>)Session["ListaArtikala"];
                listaArtikala.Add(artikal);
                Session["ListaArtikala"] = listaArtikala;
            }
            else
            {
                List<Artikal> listaArtikala = new List<Artikal>();
                listaArtikala.Add(artikal);
                Session["ListaArtikala"] = listaArtikala;
            }
            return View(Session["ListaArtikala"]);
        }
    }
}