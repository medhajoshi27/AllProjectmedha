using assignment6.Repository;
using assignment6.Repository.Entity;
using assignment6.Service;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace assignment6.Controllers
{
    public class HomeController : Controller
    {
        private Employeecontext db = new Employeecontext();

        // GET: Home
        private readonly IEmployeeService employeeservice;

        public ActionResult Index()
        {
            return View(db.Employees.ToList());
        }
        public HomeController(IEmployeeService employeeService)
        {
            this.employeeservice = employeeService;
        }
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Emp1 emp = db.Employees.Find(id);
            if (emp == null)
            {
                return HttpNotFound();
            }
            return View(emp);
        }

        // POST: Products/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Email,Phone,MaritalStatus,State,City")] Emp1 emp)
        {
            if (ModelState.IsValid)
            {
                db.Employees.Add(emp);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(emp);
        }

        // GET: Products/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Emp1 employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Email,Phone,MaritalStatus,State,City")] Emp1 employee)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employee).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        // GET: Products/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Emp1 emp = db.Employees.Find(id);
            if (emp == null)
            {
                return HttpNotFound();
            }
            return View(emp);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Emp1 product = db.Employees.Find(id);
            db.Employees.Remove(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}