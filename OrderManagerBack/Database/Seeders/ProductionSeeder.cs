using Microsoft.EntityFrameworkCore;
using OrderManagerBack.Entities;
using OrderManagerBack.Models;

namespace OrderManagerBack.Database.Seeders
{
    public class ProductionSeeder
    {
        private readonly DbContext _context;

        public ProductionSeeder(DbContext context)
        {
            _context = context;
        }

        public void Populate()
        {
            var productionTests = _context.Set<Production>().FirstOrDefault();

            if (productionTests == null)
            {
                var user = _context.Set<User>().First()!;
                
                var ordemChanfrador = _context.Set<Order>().Where(p => p.Product.ProductCode == "001").First()!;
                var ordemCanetaBic = _context.Set<Order>().Where(p => p.Product.ProductCode == "002").First()!;

                var ferro = _context.Set<Material>().Where(m => m.MaterialCode == "001").First()!;
                var plastico = _context.Set<Material>().Where(m => m.MaterialCode == "003").First()!;

                _context.Set<Production>().AddRange(
                    new Production()
                    {
                        Email = user.Email,
                        OrderObj = ordemChanfrador,
                        Material = ferro,
                        Quantity = 100.0m,
                        Date = DateTime.Parse("08:30"),
                        CycleTime = 7m, // 7 segundos
                    },
                    new Production()
                    {
                        Email = user.Email,
                        OrderObj = ordemCanetaBic,
                        Material = plastico,
                        Quantity = 50.0m,
                        Date = DateTime.Parse("10:30"),
                        CycleTime = 3m, // 3 segundos
                    }
                );
            }

            _context.SaveChanges();
        }
    }
}
