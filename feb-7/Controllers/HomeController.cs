using feb_7.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace feb_7.Controllers
{
    public class HomeController : Controller
    {
        feb7Entities1 db = new feb7Entities1();

        public ActionResult Index()
        {
            return View(db.Comments.ToList());
        }
 
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
    
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}