using E_CommerceWebsiteSystem1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_CommerceWebsiteSystem1
{
    internal class ECommerceContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }


        public DbSet<OrderProduct> OrderProducts { get; set; }

        public DbSet<Review> Reviews { get; set; }


    }
}