using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BrojGodina.Models;

namespace BrojGodina.Controllers
{
    public class TemplHtmlHelperiController : Controller
    {
        // GET: TemplHtmlHelperi
        public ActionResult HtmlEditorView()
        {
            return View(new OsobaTempl());
        }
        [HttpPost]
        public ViewResult HtmlEditorView(OsobaTempl osoba)
        {
            return View("HtmlLabelDisplay", osoba);
        }
        // GET: TemplHtmlHelperi
        public ActionResult EditorModelView()
        {
            return View(new OsobaTempl());
        }
        [HttpPost]
        public ViewResult EditorModelView(OsobaTempl osoba)
        {
            return View("HtmlLabelDisplay", osoba);
        }

    }
}