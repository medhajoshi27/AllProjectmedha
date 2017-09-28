using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.Entity;

namespace WebApplication4.Models
{
    public class CustomerContext : DbContext
    {
        public CustomerContext() : base("name=MyConnectionString")
        {

        }
        public DbSet<Customer> Customers { get; set; }
    }

    
}