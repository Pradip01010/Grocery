using System.ComponentModel.DataAnnotations;

namespace Online_Grocey.Models
{
    public class Discount
    {
        [Key]
        public int DiscountID { get; set; }
        [Required]
        [StringLength(250)]
        public required string DiscountTitle { get; set; }
        [Required]
        [StringLength(50)]
        public string CouponCode { get; set; }
        [Required]
        [StringLength(500)]
        public required string DiscountDescription { get; set; }
        public int Discount_Percent { get; set; }
    }
}
