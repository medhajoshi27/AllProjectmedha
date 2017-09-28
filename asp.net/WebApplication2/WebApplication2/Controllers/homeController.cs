using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        IList<Customer> customList = new List<Customer>() {
                    new Customer(){ ID=1, Name="John", Age = 18 , Phone=120354},
                    new Customer(){ID=2, Name="Steve", Age = 21, Phone=120354 },
                    new Customer(){ ID=3,Name="Bill", Age = 25,Phone=120354 },
                    new Customer(){ ID=4, Name="Ram", Age = 20,Phone=120354 },
                    new Customer(){ ID=5, Name="Ron", Age = 31,Phone=120354 },
                    new Customer(){ ID=6, Name="Chris", Age = 17,Phone=120354 },
                    new Customer(){ ID=7, Name="Rob", Age = 19,Phone=120354 }
                };

        public ActionResult Edit(int ID)
        {
          
            var cst = customList.Where(s => s.ID == ID).FirstOrDefault();

            return View(cst);
        }
    }
}