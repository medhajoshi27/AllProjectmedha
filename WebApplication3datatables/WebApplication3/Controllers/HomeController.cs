using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        //It fetches Customer data from server
        public ActionResult GetData()
        {
            using (EmployeeContext db = new EmployeeContext())
            {
                var CustomerData = db.Employees.OrderBy(a => a.Name).ToList();
                return Json(new { data = CustomerData }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}