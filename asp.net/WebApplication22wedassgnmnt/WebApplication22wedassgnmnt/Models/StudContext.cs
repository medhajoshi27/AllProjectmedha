using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication22wedassgnmnt.Models
{
    public class StudContext : DbContext
    {
        public DbSet<Student1> Students1 { get; set; }
        public DbSet<StudDetails> StudDetail { get; set; }
        public DbSet<StudentVM> studvm { get; set; }
        public StudContext() : base("MyConnectionString")
        {

        }

       
    }
}