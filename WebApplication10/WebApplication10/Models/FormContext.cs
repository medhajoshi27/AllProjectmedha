using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace WebApplication10.Models
{
    public class FormContext : DbContext
    {
        public FormContext() : base("name=MyConnectionString")
        {

        }
        public DbSet<Sign_Up> Logins { get; set; }
    }
}