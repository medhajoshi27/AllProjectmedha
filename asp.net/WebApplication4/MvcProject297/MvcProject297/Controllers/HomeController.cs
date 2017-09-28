using MvcProject297.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProject297.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Student model)
        {
            var q = new StudentContext();

            if(string.IsNullOrEmpty(model.Student_Name))
            {
                ModelState.AddModelError("Student_Name", "Name is required");
            }
            if (string.IsNullOrEmpty(model.Student_Age))
            {
                ModelState.AddModelError("Student_Age", "Age is required");
            }
            if (string.IsNullOrEmpty(model.Email))
            {
                ModelState.AddModelError("Email", "Email is required");
            }
            if (string.IsNullOrEmpty(model.Qualification))
            {
                ModelState.AddModelError("Qualification", "This field is required");
            }
            if (ModelState.IsValid)
            {
                q.StuList.Add(model);
                q.SaveChanges();
                return RedirectToAction("List");
            }
            return View();
        }
       
        public ActionResult List()
        {
            var q = new StudentContext();

         
            var st = from s in q.StuList
                                 select s;
            return View(st);
        }
    }
}