using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using week5.Models;

namespace week5.Controllers
{
    public class HomeController : Controller
    {
        EmployeeiContext context = new EmployeeiContext();
        public ActionResult Index()
        {
             var empList = new List<Employee>();
            return View(context.Employees.ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {

            EmployeeViewModel employeeViewModel = new EmployeeViewModel();
            employeeViewModel.StateList= context.States.ToList();
            employeeViewModel.CityList = context.Cities.ToList();           

            return View("Create", employeeViewModel);
        }
        [HttpPost]
        public ActionResult Create(EmployeeViewModel employeeViewModel)
        {

            if (ModelState.IsValid)
            {
                Employee employee = new Employee();
                employee.CityId = employeeViewModel.CityId;
                employee.StateId = employeeViewModel.StateId;
                employee.EmployeeName = employeeViewModel.EmployeeName;
                employee.Marital_Status = employeeViewModel.Marital_Status;
                employee.Phone = employeeViewModel.Phone;
                employee.Email = employeeViewModel.Email;           

                context.Employees.Add(employee);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            EmployeeViewModel emp = new EmployeeViewModel();
            emp.StateList = new List<State>();
            emp.CityList = new List<City>();
            emp.StateList = context.States.ToList();
            emp.CityList = context.Cities.ToList();
            return View(emp);
            

        }
        public ActionResult GetData()
        {   
                var Empdata = context.Employees.OrderBy(a => a.EmployeeName).ToList();
                return Json(new { data = Empdata }, JsonRequestBehavior.AllowGet);
           
        }
        public ActionResult FillCity(int state)
        {
            var cities = context.Cities.Where(c => c.StateId == state);
            return Json(cities, JsonRequestBehavior.AllowGet);
        }
    }
}