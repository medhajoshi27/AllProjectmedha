using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebApplication10.Models;

namespace WebApplication10.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }


        [HttpGet]
        public ActionResult Signup()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Signup(Sign_Up user)
        {
            var u = new Models.FormContext();
            u.Logins.Add(user);
            u.SaveChanges();

            return View();
        }
    }
}