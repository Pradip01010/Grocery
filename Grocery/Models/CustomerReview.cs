using System.ComponentModel.DataAnnotations;

namespace Online_Grocey.Models
{
    public class CustomerReview
    {
        [Key]
        public int CustomerReviewID { get; set; }
        [Required]
        [StringLength(50)]
        public required string CustomerRevieww { get; set; }
    }
}