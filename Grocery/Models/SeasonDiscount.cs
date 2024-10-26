using System.ComponentModel.DataAnnotations;

namespace Online_Grocey.Models
{
    public class SeasonDiscount
    {
        [Key]
        public int SeasonDiscountID { get; set; }
        [Required] // Ensures the property is not nullable
        public int Discount_Percent { get; set; }
    }
}
