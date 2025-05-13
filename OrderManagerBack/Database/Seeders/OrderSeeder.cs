using Microsoft.EntityFrameworkCore;
using OrderManagerBack.Models;

namespace OrderManagerBack.Database.Seeders
{
    public class OrderSeeder
    {
        private readonly DbContext _context;

        public OrderSeeder(DbContext context)
        {
            _context = context;
        }

        public void Populate()
        {
            var orderTest = _context.Set<Order>().FirstOrDefault();

            if (orderTest == null)
            {
                var chanfrador = _context.Set<Product>().Where(p => p.ProductCode == "001").First()!;
                var canetaBic = _context.Set<Product>().Where(p => p.ProductCode == "002").First()!;

                _context.Set<Order>().AddRange(
                    new Order()
                    {
                        OrderCode = "001",
                        Product = chanfrador,
                        Quantity = 100.0m,
                    },
                    new Order()
                    {
                        OrderCode = "002",
                        Product = canetaBic,
                        Quantity = 50.0m
                    }
                );
            }

            _context.SaveChanges();
        }
    }
}
