using System.ComponentModel.DataAnnotations;

namespace Online_Grocey.Models
{
    public class PaymentType
    {
        [Key]
        public int PaymentTypeID { get; set; }
        [Required]
        [StringLength(100)]
        public string PaymentTypee { get; set; }
    }
}