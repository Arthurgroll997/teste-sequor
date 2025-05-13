using Microsoft.EntityFrameworkCore;
using OrderManagerBack.Models;

namespace OrderManagerBack.Database.Seeders
{
    public class ProductSeeder
    {
        private readonly DbContext _context;

        public ProductSeeder(DbContext context)
        {
            _context = context;
        }

        public void Populate()
        {
            var productTest = _context.Set<Product>().FirstOrDefault();

            if (productTest == null)
            {
                var ferro = _context.Set<Material>().Where(m => m.MaterialCode == "001").First()!;
                var aluminio = _context.Set<Material>().Where(m => m.MaterialCode == "002").First()!;
                var plastico = _context.Set<Material>().Where(m => m.MaterialCode == "003").First()!;

                _context.Set<Product>().AddRange(
                    new Product()
                    {
                        ProductCode = "001",
                        ProductDescription = "Chanfrador",
                        Materials = [ ferro, aluminio ],
                        Image = "chanfrador.jpg",
                        CycleTime = 9m, // 9 segundos
                    },
                    new Product()
                    {
                        ProductCode = "002",
                        ProductDescription = "Caneta BIC",
                        Materials = [ aluminio, plastico ],
                        Image = "caneta_bic.jpg",
                        CycleTime = 13m,
                    }
                );
            }

            _context.SaveChanges();
        }
    }
}
