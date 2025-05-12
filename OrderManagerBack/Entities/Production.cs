using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderManagerBack.Entities
{
    [Table("Production")]
    public class Production
    {
        [Key]
        [Column("ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Essa opção satizfaz o requisito de "IDENTITY(1,1)".
        public int Id { get; set; }

        [Column(name: "Email", TypeName = "VARCHAR")]
        [MaxLength(100)]
        public string Email { get; set; }

        [Column(name: "Order", TypeName = "VARCHAR")]
        [MaxLength(50)]
        public string Order { get; set; }

        [Column(name: "Date", TypeName = "DATETIME")]
        public DateTime Date { get; set; }

        [Column(name: "Quantity", TypeName = "NUMERIC(18,2)")]
        public string Quantity { get; set; }

        [Column(name: "MaterialCode", TypeName = "VARCHAR")]
        [MaxLength(50)]
        public string MaterialCode { get; set; }

        [Column(name: "CycleTime", TypeName = "NUMERIC(18,2)")]
        public string CycleTime { get; set; }
    }
}
