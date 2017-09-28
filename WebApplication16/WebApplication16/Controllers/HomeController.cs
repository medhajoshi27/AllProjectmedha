using System.Linq;
using System.Web.Mvc;
using WebApplication16.Models;

namespace WebApplication16.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        //It fetches Customer data from server
        public ActionResult GetData()
        {
            using (EmployeeContext db = new EmployeeContext())
            {
                var EmoloyeeData = db.Employees.OrderBy(a => a.Name).ToList();
                return Json(new { data = EmoloyeeData }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}