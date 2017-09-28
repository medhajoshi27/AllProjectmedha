using assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace assignment.Controllers
{
    public class HomeController : Controller
    {
        private WorkerContext context = new WorkerContext();
        public ActionResult Index()
        {
           var studentList = new List<Worker>();
            return View(context.Workers.ToList());
         //   return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            var states = context.States.ToList();
            var countries = context.Countries.ToList();
            var viewModel = new WorkerVM
            {
                worker = new Worker(),
                List = states,
                List1 = countries
            };

            return View("Create", viewModel);
        }
        [HttpPost]
        public ActionResult Create(Worker worker)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new WorkerVM
                {
                    worker = worker,
                    List = context.States.ToList(),
                     List1 = context.Countries.ToList()
                };

                return View("Create", viewModel);
            }
            if (worker.ID == 0)
                context.Workers.Add(worker);
            else
            {
                State m1 = new State();
                Country m2 = new Country();
                var workerInDb = context.Workers.Single(c => c.ID == worker.ID);
                workerInDb.Name = worker.Name;
                workerInDb.Birthdate = worker.Birthdate;
                worker.State = m1.state;
                workerInDb.State = worker.State;
                worker.Country = m2.country;
                workerInDb.Country = worker.Country;

            }

            context.SaveChanges();

            return RedirectToAction("Index");

        }
        public ActionResult Fillstate(string state)
        {
            var states = context.States.Where(c => c.Country_Id==state);
            return Json(states, JsonRequestBehavior.AllowGet);
        }
    }
}