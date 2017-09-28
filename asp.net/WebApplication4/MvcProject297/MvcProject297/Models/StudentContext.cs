using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcProject297.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext() : base("name = StuContext") { }
        public DbSet<Student> StuList { get; set; }
    }
}