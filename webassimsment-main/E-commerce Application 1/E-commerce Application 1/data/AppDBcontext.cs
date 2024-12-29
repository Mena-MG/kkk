using E_commerce_Application_1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace E_commerce_Application_1.data
{
    public class AppDBcontext:DbContext
    {
        public AppDBcontext(DbContextOptions<AppDBcontext> f ) : base(f){ }
        public DbSet<Products> Products { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Class.0> classes { get; set; }








        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure One-to-Many Relationship
            modelBuilder.Entity<Orders>()
                .HasOne(o => o.Customer)
                .WithMany(c => c.Orders)
                .HasForeignKey(o => o.CustomerID);

            // Configure Many-to-Many Relationship
            modelBuilder.Entity<OrderItem>()
                .HasKey(oi => new { oi.OrdersID, oi.ProductID });

            modelBuilder.Entity<OrderItem>()
                .HasOne(oi => oi.Order)
                .WithMany(o => o.OrderItems)
                .HasForeignKey(oi => oi.OrdersID);

            modelBuilder.Entity<OrderItem>()
                .HasOne(oi => oi.Product)
                .WithMany(p => p.OrderItems)
                .HasForeignKey(oi => oi.ProductID);
        }
    }





}
