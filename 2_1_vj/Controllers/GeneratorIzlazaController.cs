using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _2_1_vj.Controllers
{
    public class GeneratorIzlazaController : Controller
    {
        // GET: GeneratorIzlaza
        public ActionResult RedirectNaMetodu(string id)
        {
            if (id=="Kosarica")
            {
                return RedirectToAction("PopisKosarice");
            }
            if (id=="time")
            {
                return RedirectToAction("Index", "Kontekst");
            }
            else
            {
                return RedirectToAction("LisaArtikala");
            }
        }
    }
}