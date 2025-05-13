using Microsoft.EntityFrameworkCore;
using OrderManagerBack.Entities;
using OrderManagerBack.Models;

namespace OrderManagerBack.Database.Seeders
{
    public class MaterialSeeder
    {
        private readonly DbContext _context;

        public MaterialSeeder(DbContext context)
        {
            _context = context;
        }

        public void Populate()
        {
            var materialTest = _context.Set<Material>().FirstOrDefault();

            if (materialTest == null)
            {
                _context.Set<Material>().AddRange(
                    new Material()
                    {
                        MaterialCode = "001",
                        MaterialDescription = "Ferro",
                    },
                    new Material()
                    {
                        MaterialCode = "002",
                        MaterialDescription = "Alumínio",
                    },
                    new Material()
                    {
                        MaterialCode = "003",
                        MaterialDescription = "Plástico",
                    }
                );
            }

            _context.SaveChanges();
        }
    }
}
