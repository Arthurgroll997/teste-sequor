using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using OrderManagerBack.Dto;

namespace OrderManagerBack.Models
{
    [Table("Material")]
    public class Material
    {
        [Key]
        [Column(name: "MaterialCode", TypeName = "VARCHAR")]
        [MaxLength(50)]
        public string MaterialCode { get; set; }

        [Column(name: "MaterialDescription", TypeName = "VARCHAR")]
        [MaxLength(500)]
        public string MaterialDescription { get; set; }

        public List<Product> Products { get; } = []; // Usado para dar join na tabela do meio chamada "ProductMaterial"

        public MaterialDto ToDto()
        {
            return new MaterialDto
            {
                MaterialCode = MaterialCode,
                MaterialDescription = MaterialDescription
            };
        }
    }
}
