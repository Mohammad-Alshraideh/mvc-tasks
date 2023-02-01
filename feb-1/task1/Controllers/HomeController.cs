using feb_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace feb_1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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
        public ActionResult Students() 
        {
           
            List<Student> students= new List<Student>();
             Student stud1= new Student();
            stud1.ID= 1;
            stud1.Name = "Mohammad";
            stud1.Faculity = "cs";
            stud1.Major = "cs";
            students.Add(stud1);
            Student stud2 = new Student();
            stud2.ID = 2;
            stud2.Name = "Ahmad";
            stud2.Faculity = "CS";
            stud2.Major = "CE";
            students.Add(stud2);
            Student stud3 = new Student();
         
            stud3.ID = 3;
            stud3.Name = "Yazeed";
            stud3.Faculity = "cs";
            stud3.Major = "DA";
            students.Add(stud3);
 

            return View(students);
        }
    }
}