using System.Data.Entity;

namespace WebApplication16.Models
{
    public class EmployeeContext : DbContext
        {
            public EmployeeContext() : base("name=MyConnectionString")
            {

            }

            public DbSet<Employee> Employees { get; set; }
        }
    }
