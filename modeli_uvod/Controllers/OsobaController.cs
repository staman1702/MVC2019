using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using modeli_uvod.Models;

namespace modeli_uvod.Controllers
{
    public class OsobaController : Controller
    {
        // GET: Osoba
        public ActionResult PopuniOsobu()
        {
            return View();
        }

        // POST METODA iz Osoba/PopuniOsobu
        public ActionResult PopuniOsobu(Osoba osoba)
        {
            return View(osoba);
        }
    }
}