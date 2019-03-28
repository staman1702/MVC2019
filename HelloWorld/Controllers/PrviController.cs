using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorld.Controllers
{
    public class PrviController : Controller
    {
        // GET: Prvi/MetodaSaParametrima/1212 na ovoj adresi cemo naci ga :)

        public ActionResult MetodaSaParametrima(int id)
        {

            //return View();
            return Content(id.ToString());
        }

        // GET: Prvi/DrugaMetodaSaParametrima/1212

        public ViewResult DrugaMetodaSaParametrima(int id)
        {

            return View((object)id);
            //return Content(id.ToString());
        }
    }
}