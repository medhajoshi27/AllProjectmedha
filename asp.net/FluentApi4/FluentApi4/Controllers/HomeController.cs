using FluentApi4.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace FluentApi4.Controllers
{
    public class HomeController : Controller
    {
        CustomerContext db = new CustomerContext();
        public ActionResult Index()
        {
            return View();
        }





        public JsonResult GetStudents(string sidx, string sort, int page, int rows)
        {
            
            sort = (sort == null) ? "" : sort;
            int pageIndex = Convert.ToInt32(page) - 1;
            int pageSize = rows;

            var customerlist = db.Customers.Select(
                    t => new
                    {
                        t.CustomerId,
                        t.CustomerName
                    });
            int totalRecords = customerlist.Count();
            var totalPages = (int)Math.Ceiling((float)totalRecords / (float)rows);
            if (sort.ToUpper() == "DESC")
            {
                customerlist = customerlist.OrderByDescending(t => t.CustomerName);
                customerlist = customerlist.Skip(pageIndex * pageSize).Take(pageSize);
            }
            else
            {
                customerlist = customerlist.OrderBy(t => t.CustomerName);
                customerlist = customerlist.Skip(pageIndex * pageSize).Take(pageSize);
            }
            var jsonData = new
            {
                total = totalPages,
                page,
                records = totalRecords,
                rows = customerlist
            };
            return Json(jsonData, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public string Create([Bind(Exclude = "CustomerId")] Customer Model)
        {
            
            string msg;
            try
            {
                if (ModelState.IsValid)
                {

                    db.Customers.Add(Model);
                    db.SaveChanges();
                    msg = "Saved Successfully";
                }
                else
                {
                    msg = "Validation data not successfully";
                }
            }
            catch (Exception ex)
            {
                msg = "Error occured:" + ex.Message;
            }
            return msg;
        }

        public string Edit(CustomerViewModel Model)
        {
            
            string msg;
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(Model).State = EntityState.Modified;
                    db.SaveChanges();
                    msg = "Saved Successfully";
                }
                else
                {
                    msg = "Validation data not successfully";
                }
            }
            catch (Exception ex)
            {
                msg = "Error occured:" + ex.Message;
            }
            return msg;
        }

    }
}