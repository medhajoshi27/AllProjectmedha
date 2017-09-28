using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace week4.Models
{
    public class StudentContext: DbContext
    {
        public StudentContext(): base("name=dbStudentEntries")
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}