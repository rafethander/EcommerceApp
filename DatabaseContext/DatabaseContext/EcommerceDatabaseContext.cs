using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace DatabaseContext.DatabaseContext
{
    public class EcommerceDatabaseContext:DbContext
    {
        private IConfiguration _configuration;
        public EcommerceDatabaseContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }


        public DbSet<Shop> Shops { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<PurchaseOrder> PurchaseOrders { get; set; }
        public DbSet<PurchaseOrderItem> PurchaseOrderItems { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connString = _configuration.GetConnectionString("AppDbContext");
            optionsBuilder.UseSqlServer(connString);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasKey(c => c.Id);
            modelBuilder.Entity<Shop>().HasKey(s => s.Id);
            modelBuilder.Entity<Product>().HasKey(p => p.Id);
            modelBuilder.Entity<Product>()
                .HasOne<Shop>(p => p.Shop)
                .WithMany(s => s.Products)
                .HasForeignKey(s => s.ShopId);

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasQueryFilter(p => p.IsDeleted == false);
        }
    }
}
