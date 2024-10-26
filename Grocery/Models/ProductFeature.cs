using System.ComponentModel.DataAnnotations;

namespace Online_Grocey.Models
{
    public class ProductFeature
    {
        [Key]
        public int ProductFeatureID { get; set; }

        [Required] // Ensures the property is not nullable
        public string ProductFeaturee { get; set; }
    }
}
