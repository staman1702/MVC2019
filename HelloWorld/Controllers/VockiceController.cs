using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorld.Controllers
{
    public class VockiceController : Controller
    {
        // GET: Vockice
        public ActionResult ZaForPetlju()
        {
            string[] voce = new string[] { "Jabuka", "Kruška", "Banana", "Limun" }; 
            return View(voce);
        }
    }
}