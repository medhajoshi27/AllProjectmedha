using System.Data.Entity;
using WebApplication21.Models;

namespace WebApplication.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        
        public DbSet<MembershipType> MembershipTypes { get; set; }
        
        

        public ApplicationDbContext()
            : base("MyConnection")
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}