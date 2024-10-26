using System.ComponentModel.DataAnnotations;

namespace Online_Grocey.Models
{
    public class ProductHeader
    {
        [Key]
        public int ProductHeaderID { get; set; }
        [Required] // Ensures the property is not nullable
        [StringLength(250)] // Limits the maximum length to 250 characters
        public string? ProductTitle { get; set; }

        [Required] // Ensures the property is not nullable
        public string? ProductInformation { get; set; }
        [Required] // Ensures the property is not nullable
        [StringLength(100)] // Enforces the maximum length of 100 characters
        public string? SKUCode { get; set; }
    }
}
