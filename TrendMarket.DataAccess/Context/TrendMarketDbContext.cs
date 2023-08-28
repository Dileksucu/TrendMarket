using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrendMarket.Entity;

namespace TrendMarket.DataAccess.Context
{
    public class TrendMarketDbContext:IdentityDbContext<User,Role,string>
    {
        
        public TrendMarketDbContext(DbContextOptions options) : base(options)
        {
            //Dependency Injection
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
    }


    public class TrendMarketDbContextFactory : IDesignTimeDbContextFactory<TrendMarketDbContext>
    {
        public TrendMarketDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<TrendMarketDbContext>();
            optionsBuilder.UseSqlServer("Data Source=localhost,1433;Initial Catalog=TrendMarketDb;User id=sa;Password=Pass123!;MultipleActiveResultSets=True;TrustServerCertificate=True;");

            return new TrendMarketDbContext(optionsBuilder.Options);
        }
    }
}
