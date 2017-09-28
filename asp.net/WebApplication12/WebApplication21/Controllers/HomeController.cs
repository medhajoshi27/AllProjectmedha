using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication21.Models;

namespace WebApplication21.Controllers
{
    public class HomeController : Controller
    {
        CustomerContext context;
        public HomeController()
        {
            context = new CustomerContext();
        }
        // GET: Home
        public ActionResult Index()
        {
        
            return View();
        }
        public ActionResult New()
        {
         
            var membershipTypes = context.MyDrops.ToList();
            var viewModel = new dropdwn
            {
                customer = new Customer(),
                List = membershipTypes
            };

            return View("New", viewModel);
            
        }
        [HttpPost]
        public ActionResult New(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new dropdwn
                {
                    customer = customer,
                    List = context.MyDrops.ToList()
                };

                return View("New", viewModel);
            }
            if (customer.Id == 0)
                context.Customers.Add(customer);
            else
            {
                newClass m1=new newClass();
                var customerInDb = context.Customers.Single(c => c.Id == customer.Id);
                customerInDb.Name = customer.Name;
                customerInDb.Email = customer.Email;
                customerInDb.PhnNum = customer.PhnNum;
                customerInDb.IsSubscribedToNewsletter = customer.IsSubscribedToNewsletter;
                customer.Dropdwn = m1.Name; 
                customerInDb.Dropdwn = customer.Dropdwn;


            }

            context.SaveChanges();

            return RedirectToAction("Index");
            
        }
    }
}