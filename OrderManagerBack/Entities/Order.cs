using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;
using OrderManagerBack.Database;
using OrderManagerBack.Dto;
using OrderManagerBack.Entities;

namespace OrderManagerBack.Models
{
    [Table("Order")]
    public class Order
    {
        [Key]
        [Column(name: "Order", TypeName = "VARCHAR")]
        [MaxLength(50)]
        public string OrderCode { get; set; }
        
        [Column(name: "Quantity", TypeName = "NUMERIC(18,2)")]
        public decimal Quantity { get; set; } // O tipo decimal é utilizado ao invés do double para suprir a
                                              // alta precisão de +15 dígitos recomendada.
        public Product Product { get; set; } // Simplifica para obter o produto e gera a mesma estrutura de tabela requisitada
    
        private string GetProductImage(string imagePath) =>
            Convert.ToBase64String(File.ReadAllBytes(imagePath));

        public OrderDto ToDto(string? imagePath = null)
        {
            return new()
            {
                Order = OrderCode,
                Quantity = Quantity,
                ProductCode = Product.ProductCode,
                ProductDescription = Product.ProductDescription,
                Image = imagePath is not null ? GetProductImage(Path.Combine(imagePath, Product.Image)) : Product.Image,
                CycleTime = Product.CycleTime,
                Materials = Product.Materials.Select(mat => mat.ToDto()).ToList(),
            };
        }

        public bool Exists(OrderManagerContext ctx) => ctx.Orders.Any(o => o.OrderCode == OrderCode);

        public bool IsQuantityValid(decimal quantity) => quantity > 0 && quantity <= Quantity;

        public bool HasMaterial(string materialCode) => Product.Materials.Where(m => m.MaterialCode == materialCode).Any();

        public bool WarnCycleTime(decimal cycleTime) => cycleTime < Product.CycleTime;

        public void MakeProduction(DateTime productionDate, SetProductionInputDto productionInfo, OrderManagerContext ctx)
        {
            var production = new Production()
            {
                Email = productionInfo.Email,
                OrderObj = this,
                Date = productionDate,
                Quantity = productionInfo.Quantity,
                Material = ctx.Materials.Where(m => m.MaterialCode == productionInfo.MaterialCode).First()!,
                CycleTime = productionInfo.CycleTime,
            };

            ctx.Add(production);

            ctx.SaveChanges();
        }
    }
}
