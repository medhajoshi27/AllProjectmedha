using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication21.Models
{
    public class CustomerContext :DbContext
    {
        public CustomerContext()
           : base("name=MyConnectionString")
        {
        }
        public DbSet<Customer> Customers { get; set; }

        public DbSet<newClass> MyDrops { get; set; }
    }
}