using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace jqgrid.Models
{
    public class CustomerContext:DbContext
    {
        public CustomerContext() : base("name=dbCustomerEntries")
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders{ get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .HasKey(m => m.Customer_ID)
                .Property(m => m.Customer_Name)
                .IsRequired();
            modelBuilder.Entity<Order>()
                .HasKey(t => t.Order_id)
                .Property(t => t.Price)
                .IsRequired();
            modelBuilder.Entity<Order>()
                .Property(t => t.Quantity)
                .IsRequired();
            modelBuilder.Entity<Product>()
                .HasKey(n => n.Product_Id)
                .Property(n => n.Product_Name)
                .IsRequired();
            modelBuilder.Entity<Customer>()
               .HasMany(a => a.orders)
                  .WithRequired(c => c.customer)
                   .HasForeignKey(c =>c.Customer_ID);
            modelBuilder.Entity<Product>()
             .HasMany<Order>(a => a.orders)
             .WithMany(a => a.products)
            .Map(m => m.ToTable("orderproducts"));
            base.OnModelCreating(modelBuilder);
        }
    }
}