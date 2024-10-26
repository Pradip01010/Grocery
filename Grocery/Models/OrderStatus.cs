using System.ComponentModel.DataAnnotations;

namespace Online_Grocey.Models
{
    public class OrderStatus
    {
        [Key]
        public int OrderStatusID { get; set; }
        [Required]
        [StringLength(100)]
        public string OrderStatusTitle { get; set; }
    }
}