using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderManagerBack.Entities
{
    [Table("User")]
    public class User
    {
        [Key]
        [Column(name: "Email", TypeName = "VARCHAR")]
        [MaxLength(100)]
        public string Email { get; set; }

        [Column(name: "Name", TypeName = "VARCHAR")]
        [MaxLength(50)]
        public string Name { get; set; }

        [Column(name: "InitialDate", TypeName = "DATETIME")]
        public DateTime InitialDate { get; set; }

        [Column(name: "EndDate", TypeName = "DATETIME")]
        public DateTime EndDate { get; set; }
    }
}
