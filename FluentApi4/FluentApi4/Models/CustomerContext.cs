using System.Data.Entity;

namespace FluentApi4.Models
{



    public class CustomerContext : DbContext
    {
        public CustomerContext() : base("dbFluentApiEntries")
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


         
            modelBuilder.Entity<Customer>()
                .ToTable("Customer")
                .HasKey(t => t.CustomerId)
                .HasMany(t => t.Order)
                .WithRequired(t => t.Customer);
          

           
            modelBuilder.Entity<Customer>()
                .Property(t => t.CustomerId)
                .HasColumnName("CustomerId");
         
            
            modelBuilder.Entity<Customer>()
                .Property(t => t.CustomerName)
                .HasColumnName("CustomerName");
           

           

          

         

            modelBuilder.Entity<Order>()
                .ToTable("Order")
                .HasKey(t=>t.OrderId)
                .HasMany(t=>t.Product)
                .WithRequired(t=>t.Order);

         


            
            modelBuilder.Entity<Order>()
                .Property(t => t.OrderId)
                .HasColumnName("OrderId");
           

            
            modelBuilder.Entity<Order>()
                .Property(t => t.CustomerId)
                .HasColumnName("CustomerId");


            modelBuilder.Entity<Product>()
                .ToTable("Product")
                .HasKey(t=>t.ProductId);

            modelBuilder.Entity<Product>()
                .Property(t => t.ProductId)
                .HasColumnName("ProductId");

            modelBuilder.Entity<Product>()
                .Property(t => t.OrderId)
                .HasColumnName("OrderId");

            modelBuilder.Entity<Product>()
                .Property(t => t.ProductName)
                .HasColumnName("ProductName");
        }
    }
    
}