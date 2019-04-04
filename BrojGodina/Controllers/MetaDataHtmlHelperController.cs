using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BrojGodina.Models;

namespace BrojGodina.Controllers
{
    public class MetaDataHtmlHelperController : Controller
    {
        // GET: MetaDataHtmlHelperi
        public ActionResult MetaDataView()
        {
            return View(new OsobaMeta());
        }
        [HttpPost]
        public ViewResult MetaDataView(OsobaMeta osoba)
        {
            return View("HtmlLabelDisplay", osoba);
        }
    }
}