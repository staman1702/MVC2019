using Adresar.WcfService.KontaktService;
using Adresar.WcfService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Adresar.WcfService.Controllers
{
    public class KontaktiWSController : Controller
    {
        // GET: KontaktiWS
        public ActionResult Index
        {
            
                KontaktServiceClient klijent = new KontaktServiceClient();

                List<Kontakt> kontakti = klijent.DohvatiAktivneKontakte().ToList();


                return View(kontakti);
            
        }
    }
}