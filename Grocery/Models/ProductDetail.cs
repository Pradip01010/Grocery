using System.ComponentModel.DataAnnotations;

namespace Online_Grocey.Models
{
    public class ProductDetail
    {
        [Key]
        public int ProductDetailID { get; set; }
        [Required]

        public int Quantity { get; set; }
        [Required]
        public float UnitPrice { get; set; }
        [Required]  // This makes the field not nullable
        [StringLength(50)]  // This limits the length to 50 characters
        public string BarCode { get; set; }
    }
}
