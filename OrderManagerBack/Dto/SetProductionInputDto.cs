using System.ComponentModel.DataAnnotations;

namespace OrderManagerBack.Dto
{
    public class SetProductionInputDto
    {
        [Required]
        [MaxLength(100)]
        public string Email { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string Order { get; set; }
        
        [Required]
        [MaxLength(32)]
        public string ProductionDate { get; set; }
        
        [Required]
        [MaxLength(32)]
        public string ProductionTime { get; set; }
        
        [Required]
        public decimal Quantity { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string MaterialCode { get; set; }
        
        [Required]
        public decimal CycleTime { get; set; }
    }
}
