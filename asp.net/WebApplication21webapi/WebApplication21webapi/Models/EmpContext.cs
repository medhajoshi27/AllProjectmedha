using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication21webapi.Models
{
        public class EmpContext : DbContext
        {
        public DbSet<Emp> Emps { get; set; }
    }
    
}
