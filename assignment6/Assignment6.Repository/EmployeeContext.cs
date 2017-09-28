using assignment6.Repository.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment6.Repository
{
    public class Employeecontext : DbContext
    {


        public Employeecontext() : base("name=MyConnectionString")
        {

        }
        public DbSet<Emp1> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public virtual void Commit()
        {
            base.SaveChanges();
        }
    }
}
