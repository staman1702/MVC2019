using Poklon.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Poklon.Controllers
{
    public class PoklonController : Controller
    {
        private ApplicationDbContext _db = new ApplicationDbContext();

        // GET: Poklon
        public ActionResult Index()
        {
            List<Models.Poklon> listaPoklona = (from p in _db.Pokloni
                                                where p.Naruceno==false
                                         select p).ToList();
            return View(listaPoklona);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Models.Poklon poklon)
        {
            if (ModelState.IsValid)
            {
                _db.Pokloni.Add(poklon);
                _db.SaveChanges();
                
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult OznaciNaruceno(int id)
        {
            Models.Poklon p = _db.Pokloni.Find(id);
            p.Naruceno = true;
            _db.Entry(p).State = EntityState.Modified;
            _db.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}