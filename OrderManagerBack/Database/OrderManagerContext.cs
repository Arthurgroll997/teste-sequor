using System.Runtime.ConstrainedExecution;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
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
        }
    }
}
