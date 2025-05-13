using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

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
    }
}
