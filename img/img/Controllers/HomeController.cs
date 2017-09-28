using img.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace img.Controllers
{
    public class HomeController : Controller
    {
        private ArtWorkContext db = new ArtWorkContext();

        public ActionResult Create(ArtWork artwork, HttpPostedFileBase image)
        {
            if (ModelState.IsValid)
            {
                if (image != null)
                {
                    //attach the uploaded image to the object before saving to Database
                    artwork.ImageMimeType = image.ContentLength;
                    artwork.ImageData = new byte[image.ContentLength];
                    image.InputStream.Read(artwork.ImageData, 0, image.ContentLength);

                    //Save image to file
                    var filename = image.FileName;
        var filePathOriginal = Server.MapPath("/Downloads");
        var filePathThumbnail = Server.MapPath("/Downloads");
        string savedFileName = Path.Combine(filePathOriginal, filename);
        image.SaveAs(savedFileName);
                    
                    //Read image back from file and create thumbnail from it
                    var imageFile = Path.Combine(Server.MapPath("~/Downloads"), filename);
                    using (var srcImage = Image.FromFile(imageFile))
                    using (var newImage = new Bitmap(100, 100))
                    using (var graphics = Graphics.FromImage(newImage))
                    using (var stream = new MemoryStream())
                    {
                        graphics.SmoothingMode = SmoothingMode.AntiAlias;
                        graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                        graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                        graphics.DrawImage(srcImage, new Rectangle(0, 0, 100, 100));
                        newImage.Save(stream, ImageFormat.Png);
                        var thumbNew = File(stream.ToArray(), "image/png");
    artwork.ArtworkThumbnail = thumbNew.FileContents;
                    }                
                }

               //Save model object to database
                db.ArtWorks.Add(artwork);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(artwork);
        }
        public FileContentResult GetThumbnailImage(int artworkId)
        {
            ArtWork art = db.ArtWorks.FirstOrDefault(p => p.ArtWorkId == artworkId);
            if (art != null)
            {
                return File(art.ArtworkThumbnail, art.ImageMimeType.ToString());
            }
            else
            {
                return null;
            }
        }
    }
}