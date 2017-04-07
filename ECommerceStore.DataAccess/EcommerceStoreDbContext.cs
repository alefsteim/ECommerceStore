using System;
using System.Collections.Generic;
using System.Linq;
using ECommerceStore.DomainModel.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ECommerceStore.DataAccess
{
    public class ECommerceStoreDbContext : DbContext
    {
        public ECommerceStoreDbContext(DbContextOptions<ECommerceStoreDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }

        public void EnsureSeedData()
        {
            if (this.Products.Any())
            {
                return;

            }

            var products = new List<Product>()
            {
                new Product { Name="Computer", Description="Indispensable office stuff", Price=423.44d},
                new Product { Name="TV-set", Description="Indispensable home stuff",Price=225.44d},
                new Product {Name = "Microwave owen", Description = "Yummy!!",Price=233.44d}
            };

            Products.AddRange(products);
            SaveChanges();
        }
    }
}
