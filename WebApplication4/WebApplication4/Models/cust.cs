using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication4.Models;

namespace WebApplication4.Models
{
    public class cust : DbContext
    {
        public cust() : base("name=MyConnectionString")
        {
        }
        public virtual DbSet<Customer> Customers { get; set; }
    }
}