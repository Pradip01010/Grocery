using System.ComponentModel.DataAnnotations;

namespace Online_Grocey.Models
{
    public class Brand
    {
        [Key]
        public int BrandID { get; set; }
        [Required]
        [StringLength(150)]
        public required string BrandIitle { get; set; }
    }
}
