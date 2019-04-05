using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kotrola_gresaka.Models;

namespace Kotrola_gresaka.Controllers
{
    public class ValidacijeController : Controller
    {
        // GET: Validacije
        public ActionResult IzdavanjeRacuna()
        {
            return View(new Racun() { Datum = DateTime.Now, BrojRacuna = "/" + DateTime.Now.Year.ToString() });
        }

        [HttpPost]
        public ViewResult IzdavanjeRacuna(Racun racun, string id)
        {
            //obavezne vrijednosti
            if (string.IsNullOrEmpty(racun.BrojRacuna))
            {
                ModelState.AddModelError("BrojRacuna", "Broj računa je obavezan!");
            }
            if (string.IsNullOrEmpty(racun.Zaposlenik))
            {
                ModelState.AddModelError("Zaposlenik", "Zaposlenik je obavezan!");
            }
            if (string.IsNullOrEmpty(racun.Kupac))
            {
                ModelState.AddModelError("Kupac", "Kupac je obavezan!");
            }

            //model-level validacija
            if (ModelState.IsValidField("Datum"))
            {
                if(racun.Datum < DateTime.Today.AddDays(-3))
                    {
                    ModelState.AddModelError("", "Datum ne smije biti manji za više od 3 dana.");
                }
            }

            //ukupna provjera validacije
            if (ModelState.IsValid)
            {
                return View("RacunIzdan", racun);
            }
            else
            {
                if (id =="IzdavanjeRacuna2")
                {
                    return View("IzdavanjeRacuna2");
                }
                else
                {
                return View();
                }
            }
            

        }
        public ViewResult IzdavanjeRacuna2()
        {
            return View(new Racun() { Datum = DateTime.Now, BrojRacuna = "/" + DateTime.Now.Year.ToString() });
        }
    }
}