using feb_13.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace feb_13.Controllers
{
    public class HomeController : Controller
    {
        feb13Entities db = new feb13Entities();
        public ActionResult Index(int id)
        {
            var fac = db.Faculties.Where(x => x.id == id);
            ViewBag.Title = "Home Page";

            return View(fac.FirstOrDefault());
        }
    }
}
