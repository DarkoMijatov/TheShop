using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Shop.Core.Models;
using System.Configuration;
using System.Reflection;

namespace Shop.Core.Data
{
    public class ShopDbContext : DbContext
    {
        public ShopDbContext()
        {
        }
        public ShopDbContext(DbContextOptions<ShopDbContext> options)
            : base(options)
        {
        }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Buyer> Buyers { get; set; }
        public DbSet<Models.Shop> Shops { get; set; }
        public DbSet<Shopping> Shoppings { get; set; }
        public DbSet<ShoppingArticle> ShoppingArticles { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<SupplyOrder> SupplyOrders { get; set; }
        public DbSet<SupplyOrderArticle> SupplyOrderArticles { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["ShopDbConnectionString"].ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}