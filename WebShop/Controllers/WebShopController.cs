using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using WebShop.Models;


namespace WebShop.Controllers
{
    public class WebShopController : Controller
    {
        //konekcija
        private WebShopEntities db = new WebShopEntities();

        // GET: WebShop
        public ActionResult Index()
        {
            var proizvodi = db.Proizvodis.Include(p => p.MjereProizvoda);
            return View(proizvodi.ToList());
        }
    }
}