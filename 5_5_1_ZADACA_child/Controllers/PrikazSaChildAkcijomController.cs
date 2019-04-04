using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _5_5_1_ZADACA_child.Models;

namespace _5_5_1_ZADACA_child.Controllers
{
    public class PrikazSaChildAkcijomController : Controller
    {
        // GET: PrikazSaChildAkcijom
        public ActionResult ObradiListu()
        {
            List<Artikal> listaArtikala = new List<Artikal>()
            {
                new Artikal(){Naziv="Seka", Cijena=8.99M, Kategorija="Čokolada" },
                new Artikal(){Naziv="Jadro", Cijena=10.99M, Kategorija="Keks"},
                new Artikal(){Naziv="Braco", Cijena=8.99M, Kategorija="Čokolada"}
            };            ;
            return View(listaArtikala);
        }

        [ChildActionOnly]
        public string OdrediKategoriju(Artikal artikal)
        {
            return artikal.Kategorija;
        }
    }
}