using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;
using OrderManagerBack.Dto;

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
    
        public OrderDto ToDto()
        {
            return new()
            {
                Order = OrderCode,
                Quantity = Quantity,
                ProductCode = Product.ProductCode,
                ProductDescription = Product.ProductDescription,
                Image = Product.Image,
                CycleTime = Product.CycleTime,
                Materials = Product.Materials.Select(mat => mat.ToDto()).ToList(),
            };
        }
    }
}
