using bundle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace bundle.Controllers
{
    public class HomeController : Controller
    {
        private EmpContext context = new EmpContext();
        public ActionResult Index()
        {
            var EmpList = new List<Employee>();
            return View(context.Employees.ToList());
        }
        [HttpGet]
       public ActionResult Create()
        {
            return View();
        }

        /*[HttpPost]
        public ActionResult Create(Employee emp)
        {

            if (ModelState.IsValid)
            {
                context.Employees.Add(emp);
                context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(emp);
        }*/
    }
}