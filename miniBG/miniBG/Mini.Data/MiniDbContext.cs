using Microsoft.EntityFrameworkCore;
using Mini.Data.Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace Mini.Data
{
    public class MiniDbContext : DbContext
    {
        public MiniDbContext()
        {
        }

        public virtual DbSet<Salon> Salons { get; set; }

        public virtual DbSet<SalonItem> SalonItems { get; set; }

        public virtual DbSet<SalonAddress> SalonAddresses { get; set; }

        public virtual DbSet<Product> Products { get; set; }

        public virtual DbSet<ProductItem> ProductItems { get; set; }

        public virtual DbSet<Order> Orders { get; set; }

        public virtual DbSet<Address> Addresses { get; set; }

        public virtual DbSet<Customer> Customers { get; set; }

        public virtual DbSet<CustomerAddress> CustomerAddresses { get; set; }

        public virtual DbSet<User> Users { get; set; }

        public virtual DbSet<BaseData> BaseData { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLazyLoadingProxies()
                .UseMySQL(ConfigurationManager.ConnectionStrings["Mini_Db"].ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Salon>().ToTable("Mini_Salons");
            modelBuilder.Entity<SalonItem>().ToTable("Mini_SalonItems");
            modelBuilder.Entity<SalonAddress>().ToTable("Mini_SalonAddresss");
            modelBuilder.Entity<Product>().ToTable("Mini_Products");
            modelBuilder.Entity<ProductItem>().ToTable("Mini_ProductItems");
            modelBuilder.Entity<Order>().ToTable("Mini_Orders");
            modelBuilder.Entity<Address>().ToTable("Mini_Addresss");
            modelBuilder.Entity<Customer>().ToTable("Mini_Customers");
            modelBuilder.Entity<CustomerAddress>().ToTable("Mini_CustomerAddresss");
            modelBuilder.Entity<User>().ToTable("Mini_Users");
            modelBuilder.Entity<BaseData>().ToTable("Mini_BaseData");
            base.OnModelCreating(modelBuilder);
        }
    }
}
