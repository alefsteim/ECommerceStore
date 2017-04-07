using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ECommerceStore.DataAccess
{
    public class EcommerceStoreDbContext : IdentityDbContext<IdentityUser>
    {
        public EcommerceStoreDbContext(DbContextOptions<EcommerceStoreDbContext> options) :base(options)
        {
                
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }

    }
}
