using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using OrderManagerBack.Database;

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

        public bool IsRegistered(OrderManagerContext ctx)
        {
            if (Email == null || Email == string.Empty)
                return false;

            return ctx.Users.Where(u => u.Email == Email).Any();
        }

        public bool IsValidInPeriod(DateTime period) =>
            period.Subtract(InitialDate).TotalMilliseconds > 0 && EndDate.Subtract(period).TotalMilliseconds > 0;
    }
}
