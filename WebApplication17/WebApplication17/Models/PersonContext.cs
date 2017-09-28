using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication17.Models
{
    public class PersonContext:DbContext
    {
        public PersonContext() : base("name=MyConnectionString")
            {

        }

        public DbSet<Person> Persons { get; set; }
    }
}