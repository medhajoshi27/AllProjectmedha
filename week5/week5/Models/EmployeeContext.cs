using System.Data.Entity;

namespace week5.Models
{
    public class EmployeeiContext: DbContext
    {

        public EmployeeiContext():base("name=MyConnectionString")
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<State> States { get; set; }
    }
}