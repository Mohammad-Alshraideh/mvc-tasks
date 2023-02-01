using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace jan_31.Controllers
{
    public class ShraidehController : Controller
    {
        // GET: Shraideh
        public string Index()
        {
            return $"<img '/>";
        }
        public FileResult path()
        {
            var path = Server.MapPath("~/img/bg_1.jpg");
            return File(path, "jpg" );
        }
        public string str()
        {
            return "hello";
        }
       public ContentResult cr()
        {
            int x = 1;
            return Content(x.ToString());
        }
        public ActionResult ar()
        {
            return Content("not hello");
        }
    }
}