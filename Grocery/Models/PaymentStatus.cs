using System.ComponentModel.DataAnnotations;

namespace Online_Grocey.Models
{
    public class PaymentStatus
    {
        [Key]
        public int PaymentStatusID { get; set; }
        [Required]
        [StringLength(100)]
        public string PaymentStatuss { get; set; }
    }
}
