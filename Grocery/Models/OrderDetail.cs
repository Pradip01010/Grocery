using System.ComponentModel.DataAnnotations;

namespace Online_Grocey.Models
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetailID { get; set; }
        public float UnitPrice { get; set; }
        public int Quantity { get; set; }
    }
}
