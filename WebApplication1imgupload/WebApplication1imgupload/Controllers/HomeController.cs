using System;
using System.Collections.Generic;
using SenseNet.ContentRepository;
using System.Web;
using System.Web.Mvc;
using WebApplication1imgupload.Models;

namespace WebApplication1imgupload.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        [Route("Create")]
        [HttpPost]
        public ActionResult Create(ImgVM model)
        {
            HttpPostedFileBase file = Request.Files["ImageData"];
         //  ContentRepository service = new ContentRepository();
            //int i = service.UploadImageInDataBase(file, model);
          //  if (i == 1)
            {
                return RedirectToAction("Index");
            }
            //return View(model);
        }

    }
}