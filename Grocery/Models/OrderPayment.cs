using System.ComponentModel.DataAnnotations;

namespace Online_Grocey.Models
{
    public class OrderPayment
    {
        [Key]
        public int OrderPaymentID { get; set; }

        public float TotalPayment { get; set; }
        [Required]
        [StringLength(500)]
        public string PaymentGateWay { get; set; }

    }
}
