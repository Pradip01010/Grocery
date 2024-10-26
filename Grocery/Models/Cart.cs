using System.ComponentModel.DataAnnotations;

namespace Online_Grocey.Models
{
    public class Cart
    {
        [Key]
        public int CartID { get; set; }
        [Required]

        public int Quantity { get; set; }

        [Required]
        [StringLength(50)]
        public required string UniqueNo { get; set; }
        public float UnitPrice { get; set; }
    }
}
