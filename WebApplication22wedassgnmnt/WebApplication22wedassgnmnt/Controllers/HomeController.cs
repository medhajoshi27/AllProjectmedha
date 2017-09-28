using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication22wedassgnmnt.Models;

namespace WebApplication22wedassgnmnt.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetData()
        {
            using (StudContext db = new StudContext())
            {
                var stdData = db.studvm.OrderBy(a => a.Name).ToList();
                return Json(new { data = stdData }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}