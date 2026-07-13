using E_CommerceWebsiteSystem1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_CommerceWebsiteSystem1
{
    public class ECommerceContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }


        public DbSet<OrderProduct> OrderProducts { get; set; }

        public DbSet<Review> Reviews { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //{
        //    options.UseSqlServer("Server=CODELINE;Database=ECommerceDB;Trusted_Connection=True;TrustServerCertificate=True;");
        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseSqlServer("Server=CODELINE;Database=ECommerceDB;Trusted_Connection=True;TrustServerCertificate=True;")
                    .UseLazyLoadingProxies(); // ✅ Add this line
            }
        }
    }
}