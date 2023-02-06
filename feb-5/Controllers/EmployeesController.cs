using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using actionbutton.Models;

namespace actionbutton.Controllers
{
    public class EmployeesController : Controller
    {
        private feb2Entities2 db = new feb2Entities2();

        // GET: Employees
        public ActionResult Index(string Search , string sear)
        {

            if (!string.IsNullOrEmpty(Search))
            {
                if (!string.IsNullOrEmpty(sear))
                {
                    if(sear == "FirstName")
                    return View(db.Employees.Where(x => x.First_Name.Contains(Search)));
                    if (sear == "LastName")
                        return View(db.Employees.Where(x => x.Last_name.Contains(Search)));
                    if (sear == "Email")
                        return View(db.Employees.Where(x => x.E_mail.Contains(Search)));
                }
            }




            return View(db.Employees.ToList());
        }

        // GET: Employees/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // GET: Employees/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,First_Name,Last_name,E_mail,Phone,Age,Job_Title,Gender,Img,CV")] Employee employee , HttpPostedFileBase file , HttpPostedFileBase cv)
        {
            if (ModelState.IsValid)
            {


                if (file != null && file.ContentLength > 0)
                {
                    string _FileName = Path.GetFileName(file.FileName);
                    string _path = Path.Combine(Server.MapPath("~/images"), _FileName);
                    file.SaveAs(_path);
                    employee.Img = _FileName;
                }
                else
                {
                    employee.Img = null;
                }
                if (cv != null && cv.ContentLength > 0)
                {
                    string _FileName = Path.GetFileName(cv.FileName);
                    string _path = Path.Combine(Server.MapPath("~/Document"), _FileName);
                    file.SaveAs(_path);
                    employee.CV = _FileName;
                }
                else
                {
                    employee.CV = null;
                }



                db.Employees.Add(employee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(employee);
        }

        // GET: Employees/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // POST: Employees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,First_Name,Last_name,E_mail,Phone,Age,Job_Title,Gender,Img,CV")] Employee employee, HttpPostedFileBase file , HttpPostedFileBase cv , int? id)
        {

            var existingModel = db.Employees.AsNoTracking().FirstOrDefault(x => x.id == id);
            if (ModelState.IsValid)
            {
                if (file != null && file.ContentLength > 0)
                {
                    string _FileName = Path.GetFileName(file.FileName);
                    string _path = Path.Combine(Server.MapPath("~/images"), _FileName);
                    file.SaveAs(_path);
                    employee.Img = _FileName;
                }
                else
                {
                    employee.Img = existingModel.Img;
                }
    
                if (cv != null && cv.ContentLength > 0)
                {
                    string _FileName = Path.GetFileName(cv.FileName);
                    string _path = Path.Combine(Server.MapPath("~/Document"), _FileName);
                    file.SaveAs(_path);
                    employee.CV = _FileName;
                }
                else
                {
                    employee.CV = existingModel.CV;
                }
             
                db.Entry(employee).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        // GET: Employees/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Employee employee = db.Employees.Find(id);
            db.Employees.Remove(employee);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
