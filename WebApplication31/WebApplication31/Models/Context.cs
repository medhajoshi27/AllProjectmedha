using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication31.Models
{
    public class Context: DbContext
    {
        public Context() : base("name=MyConnectionString")
        {

        }
        public DbSet<StudentMaster> Students { get; set; }

    }
}