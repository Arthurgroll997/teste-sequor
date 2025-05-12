
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderManagerBack.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        [Column(name: "ProductCode", TypeName = "VARCHAR")]
        [MaxLength(50)]
        public string ProductCode { get; set; }
        
        [Column(name: "ProductDescription", TypeName = "VARCHAR")]
        [MaxLength(50)]
        public string ProductDescription { get; set; }
        
        [Column(name: "Image", TypeName = "VARCHAR")]
        [MaxLength(500)]
        public string Image { get; set; }

        [Column(name: "CycleTime", TypeName = "NUMERIC(18, 2)")]
        public decimal CycleTime { get; set; } // Novamente, utilizado tipo decimal para cobrir a precisão de +15 dígitos do
                                               // numeric(18, 2)

        public List<Material> Materials { get; } = []; // Cria a relação entre produtos e materiais especificada no
                                                           // método "OnModelCreating" no OrderManagerContext.
    }
}
