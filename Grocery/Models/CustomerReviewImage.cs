using System.ComponentModel.DataAnnotations;

namespace Online_Grocey.Models
{
    public class CustomerReviewImage
    {
        [Key]
        public int CustomerReviewImageID { get; set; }
        [Required]
        [StringLength(50)]
        public required string ImagePath { get; set; }
    }
}