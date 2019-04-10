using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _5_2_vj.Controllers
{
    public class KalkulatorController : Controller
    {
        // GET: Kalkulator
        public ActionResult Izracunaj()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Izracunaj(decimal broj1, decimal broj2, string operacija)
        {
            ViewBag.Broj1 = broj1;
            ViewBag.Broj2 = broj2;
            
            return View((object)operacija);
        }
    }
}