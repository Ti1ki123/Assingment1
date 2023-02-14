using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class MyDbContext : DbContext 
    {
        public MyDbContext() { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfigurationRoot configuration = builder.Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("MyStoreDB"));
        }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }

        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder optionsBuilder)
        {
            optionsBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "one" },
                new Category { CategoryId = 2, CategoryName = "two" },
                new Category { CategoryId = 3, CategoryName = "three" },
                new Category { CategoryId = 4, CategoryName = "four" },
                new Category { CategoryId = 5, CategoryName = "five" },
                new Category { CategoryId = 6, CategoryName = "six" }, 
                new Category { CategoryId = 7, CategoryName = "seve" });
        }
    }
}
