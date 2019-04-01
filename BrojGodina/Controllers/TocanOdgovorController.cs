using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BrojGodina.Controllers
{
    public class TocanOdgovorController : Controller
    {
        // GET: TocanOdgovor
        // GET: BrojGodina
        public ViewResult ProvjeriOdgovor()
        {
            return View();
        }

        //post
        [HttpPost]
        public ViewResult ProvjeriOdgovor(string odgovor)
        {
            string rezultat;
            if (!string.IsNullOrEmpty(odgovor))
            {
                if (odgovor == "10")
                {
                    rezultat = "Odogovor je točan!";
                    return View((object)rezultat);
                }
                else
                {
                    rezultat = "Odogovor nije točan!";
                    return View((object)rezultat);
                }
            }
            else
            {
                rezultat = "Odgovor ne postoji!";
                return View((object)rezultat);
            }

        }

    }
}