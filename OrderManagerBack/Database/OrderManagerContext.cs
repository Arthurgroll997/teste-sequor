using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.Arm;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using OrderManagerBack.Database.Seeders;
using OrderManagerBack.Entities;
using OrderManagerBack.Models;

namespace OrderManagerBack.Database
{
    public class OrderManagerContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Production> Productions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Definição no EntityFramework da tabela many-to-many "ProductMaterial"

            modelBuilder.Entity<Product>()
                .HasMany(p => p.Materials)
                .WithMany(m => m.Products)
                .UsingEntity("ProductMaterial",
                    l => l.HasOne(typeof(Material)).WithMany().HasForeignKey("MaterialCode")
                        .HasPrincipalKey(nameof(Material.MaterialCode)),
                    r => r.HasOne(typeof(Product)).WithMany().HasForeignKey("ProductCode")
                        .HasPrincipalKey(nameof(Product.ProductCode)),
                    j => j.HasKey("ProductCode", "MaterialCode"));

            modelBuilder.Entity<Order>()
                .HasOne(o => o.Product)
                .WithMany()
                .HasForeignKey("ProductCode")
                .HasPrincipalKey(p => p.ProductCode);

            modelBuilder.Entity<Production>(production =>
            {
                production.HasOne(p => p.OrderObj)
                    .WithMany()
                    .HasForeignKey("Order")
                    .HasPrincipalKey(o => o.OrderCode);

                production.HasOne(p => p.Material)
                    .WithMany()
                    .HasForeignKey("MaterialCode")
                    .HasPrincipalKey(m => m.MaterialCode);
            });
        }

        public void Seed()
        {
            new UserSeeder(this).Populate();
            new MaterialSeeder(this).Populate();
            new ProductSeeder(this).Populate();
            new OrderSeeder(this).Populate();
            new ProductionSeeder(this).Populate();
        }
    }
}
