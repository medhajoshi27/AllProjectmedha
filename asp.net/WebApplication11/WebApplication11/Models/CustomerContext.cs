using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication11.Models
{
    public class CustomerContext : DbContext
    {
        public CustomerContext() : base("name=MyConnectionString")
        {

        }
        public DbSet<Customer> Customers { get; set; }
      public DbSet<MembershipType> MembershipTypes { get; set; }
    }
}