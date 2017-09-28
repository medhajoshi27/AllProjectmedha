using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using week4.Models;

namespace week4.Controllers
{
    public class HomeController : Controller
    {
        private StudentContext context = new StudentContext();
        public ActionResult Index()
        {
            var studentList = new List<Student>();
            return View(context.Students.ToList());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student std)
        {
            if (string.IsNullOrEmpty(std.Student_Name))
            {
                ModelState.AddModelError("Student_Name", "Name is required");
            }
            if (string.IsNullOrEmpty(std.Email))
            {
                ModelState.AddModelError("Email", "Email is required");
            }
            if (string.IsNullOrEmpty(std.Qualification))
            {
                ModelState.AddModelError("Qualification", "This field is required");
            }
            if (string.IsNullOrEmpty(std.Marital_Status))
            {
                ModelState.AddModelError("Marital_Status", "This field is required");
            }

            if (ModelState.IsValid)
            {
                context.Students.Add(std);
                context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}