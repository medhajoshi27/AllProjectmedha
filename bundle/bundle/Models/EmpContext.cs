using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace bundle.Models
{
    public class EmpContext : DbContext
    {
        public EmpContext() : base("name=MyConnectionString")
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}