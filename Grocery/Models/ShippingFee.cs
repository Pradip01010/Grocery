using System.ComponentModel.DataAnnotations;

namespace Online_Grocey.Models
{
    public class ShippingFee
    {
        [Key]
        public int ShippingFeeID { get; set; }
        [Required]
        public float ShippingFees { get; set; }
        [Required] // Ensures the property is not nullable
        public DateTime DeliveryTimeDays { get; set; }
    }
}
