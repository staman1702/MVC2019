using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BrojGodina.Controllers
{
    public class ChildActionController : Controller
    {
        // GET: ChildAction
        public ViewResult ChildActionView()
        {
            string[] proizvodi = new string[] { "Banana", "Jabuka", "Kivi", "Mrkva", "Kupus", "Zec" };
            return View(proizvodi);
        }

        //za sprijeciti direktno pozivanje/zloupotrebu kao obicna metoda ide ovaj annotation
        [ChildActionOnly]
        public string OdrediGrupuProizvoda(string proizvod)
        {
            switch (proizvod)
            {
                case "Banana":
                case "Jabuka":
                case "Kivi":
                    return "voće";
                case "Mrkva":
                case "Kupus":
                    return "povrće";
                default:
                    return "nepoznato";
                
            }
        }
    }
}