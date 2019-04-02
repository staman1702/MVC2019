using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using BrojGodina.Models.Artikal;(ne treba aperentli)

namespace BrojGodina.Controllers
{
    public class ParcijalniKontrolerController : Controller
    {
        // GET: ParcijalniKontroler
        public ActionResult PrikaziKosaricu()
        {
            List<Artikal> ListaArtikala = new List<Artikal>()
            {
                new Artikal(){Cijena=9.99M, Kategorija="plava", Kolicina=5, Naziv="Keks"},
                new Artikal(){Cijena=8.99M, Kategorija="zelena", Kolicina=7, Naziv="Kifla"},
                new Artikal(){Cijena=5.99M, Kategorija="zuta", Kolicina=8, Naziv="Kroki"}
            };
            return View(ListaArtikala);
        }
    }
}