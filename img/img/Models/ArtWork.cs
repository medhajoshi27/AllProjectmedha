using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace img.Models
{
    public class ArtWork
    {
        public int ArtWorkId { get; set; }
        public byte[] ArtworkThumbnail { get; set; }
        public int ImageMimeType { get; set; }
        public byte[] ImageData { get; set; }
    }
}