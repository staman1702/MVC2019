using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BrojGodina.Models;

namespace BrojGodina.Controllers
{
    
    public class HtmlHelpersController : Controller
    {
        private string[] mjesta = new string[] { "Split", "Osijek", "Rijeka", "Zagreb" };

        // GET: HtmlHelpers
        public ViewResult FormHelper()
        {
            ViewBag.Mjesta = this.mjesta;
            return View(new Osoba());
        }

        [HttpPost]
        public ViewResult FormHelper(Osoba osoba)
        {
            ViewBag.Mjesta = this.mjesta;
            ViewBag.Poruka = "Podaci unešeni!";
            return View(osoba);
        }

        // GET: HtmlHelpers
        public ViewResult StrongTypeFormHelper()
        {
            ViewBag.Mjesta = this.mjesta;
            return View(new Osoba());
        }

        [HttpPost]
        public ViewResult StrongTypeFormHelper(Osoba osoba)
        {
            ViewBag.Mjesta = this.mjesta;
            ViewBag.Poruka = "Podaci unešeni!";
            return View(osoba);
        }
    }
}