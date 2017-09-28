using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace img.Models
{
    public class ArtWorkContext:DbContext
    {
        public ArtWorkContext() : base("name=MyConnectionString")
        {

        }
        public DbSet<ArtWork> ArtWorks { get; set; }
    }
}