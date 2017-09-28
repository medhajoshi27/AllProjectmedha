using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WebApplication4.Models;
using System.Net;
using System.Data.Entity;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        private CustomerContext context = new CustomerContext();
      
        public ActionResult Index()
        {
            var CustomerList = new List<Customer>();
           return View(context.Customers.ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Customer customer)
        {

            if (ModelState.IsValid)
            {
                context.Customers.Add(customer);
                context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(customer);
        }

        public ActionResult Details()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Details(int? Id)
        {
            if (Id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            Customer cu = context.Customers.Find(Id);
            if (cu == null)
                return HttpNotFound();
            return View(cu);
        }
      [HttpGet]
        public ActionResult Edit(int? Id)
        {
            {
                if (Id == null)
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                Customer c = context.Customers.Find(Id);
                if (c == null)
                    return HttpNotFound();
                return View(c);
            }
        }
        [HttpPost]
        public ActionResult Edit(Customer custom)
        {
                if (ModelState.IsValid)
                {
                    context.Entry(custom).State = EntityState.Modified;
                    context.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(custom);
        }
        [HttpGet]
        public ActionResult Delete(int? Id)
        {
            {
                if (Id == null)
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                Customer customer = context.Customers.Find(Id);
                if (customer == null)
                    return HttpNotFound();
                return View(customer);
            }
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult ConfirmDelete(int? Id, Customer cust)
        {
                Customer cm = new Customer();
                if (ModelState.IsValid)
                {
                    if (Id == null)
                        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                    cust = context.Customers.Find(Id);
                    if (cust == null)
                        return HttpNotFound();
                    context.Customers.Remove(cust);
                    context.SaveChanges();
                    return RedirectToAction("Index");

                }

                return View(cust);
        }
    }
}