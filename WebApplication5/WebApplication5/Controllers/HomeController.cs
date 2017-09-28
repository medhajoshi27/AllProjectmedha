using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    public class HomeController : Controller
    {
        public object objList { get; private set; }

        // GET: Home
        public ActionResult Index()
        {
            List<students> objList = new List<students>();
            for (int i = 1; i <= 5; i++)
            {
                students obj = new students();
                obj.ID = 1;
                obj.name = "abc";
                objList.Add(obj);
            }
            return View(objList);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(students std)
        {
            return View();
        }
        public ActionResult Edit(string name)
        {
            var std = objList.where(s => s.name == name).FirstOrDefault();
            return View(std);
        }
        [HttpPost]
        public ActionResult Edit(students std)
        {
            return View();
        }
    }
}