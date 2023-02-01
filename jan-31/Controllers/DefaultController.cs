using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace jan_31.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public string Index()
        {
            return "<a href='img/bg_1.jpg' download><img src='img/bg_1.jpg' style='width:200px'/></a>";

        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public ActionResult download()
        {
            var filePath = Server.MapPath("~/img/bg_1.jpg");
            return File(filePath, "jpg", "el-bg_1.jpg");
             
            
        }
        public string About()
        {

            return "<h1>About us <h1/>";


        }
        public string Contact()
        {

            return "<h1>Contact us <h1/>";


        }
    }
}