using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace ECommerceStore.DataAccess
{
    public class ECommerceStoreDbContextFactory : IDbContextFactory<ECommerceStoreDbContext>
    {
        public ECommerceStoreDbContext Create(DbContextFactoryOptions options)
        {
            var builder = new DbContextOptionsBuilder<ECommerceStoreDbContext>();
            builder.UseSqlServer("Server=.;Database=ECommerceStoreDb;Trusted_Connection=True;MultipleActiveResultSets=true");
            return new ECommerceStoreDbContext(builder.Options);
        }
    }
}
