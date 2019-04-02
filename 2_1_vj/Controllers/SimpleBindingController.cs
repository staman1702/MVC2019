using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _2_1_vj.Controllers
{
    public class SimpleBindingController : Controller
    {
        // GET: localhost:53666/SimpleBinding/SimpleBindMetoda
        public ViewResult SimpleBindMetoda()
        {
            return View("SimpleBind");
        }
        // POST: simpleBind - ova metoda se moze pozvati iskljucivo sa ukljucenim "post" 

            //(jerbo u viewu smo pod method stavili "POST")
        [HttpPost]
        public ViewResult SimpleBindMetoda(string ime)
        {
            string pozdrav = "Pozdrav, " + ime + "!";
            return View("SimpleBind", (object)pozdrav);
        }
    }
}