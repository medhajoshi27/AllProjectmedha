using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication3.Models
{
    public class EmployeeContext:DbContext
    {
        public EmployeeContext() : base("name=MyConnectionString")
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}