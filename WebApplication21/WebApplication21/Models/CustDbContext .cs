using System.Data.Entity;
using WebApplication21.Models;

namespace WebApplication.Models
{
    public class CustDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        
        public DbSet<MembershipType> MembershipTypes { get; set; }
        
        

        public CustDbContext()
            : base("MyConnection")
        {
        }

        public static CustDbContext Create()
        {
            return new CustDbContext();
        }
    }
}