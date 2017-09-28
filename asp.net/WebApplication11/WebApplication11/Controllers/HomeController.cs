using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication11.Models;

namespace WebApplication11.Controllers
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

                var membershipTypes = context.MembershipTypes.ToList();
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
                        List = context.MembershipTypes.ToList()
                    };

                    return View("New", viewModel);
                }
                if (customer.Id == 0)
                    context.Customers.Add(customer);
                else
                {
                    MembershipType m1 = new MembershipType();
                    var customerInDb = context.Customers.Single(c => c.Id == customer.Id);
                    customerInDb.Name = customer.Name;
                    customerInDb.IsSubscribedToNewsletter = customer.IsSubscribedToNewsletter;
                    customer.Memebers = m1.Name;
                    customerInDb.Memebers = customer.Memebers;


                }

                context.SaveChanges();

                return RedirectToAction("Index");

            }
        }
}
