using System.ComponentModel.DataAnnotations;

namespace Online_Grocey.Models
{
    public class OrderHeader
    {
        [Key]
        public int OrderHeaderID { get; set; }
        public int UserAddressID { get; set; }
        public float TotalCost { get; set; }
        public float DiscountAmount { get; set; }
        public float TotalPayement { get; set; }
        public DateTime OrderDate { get; set; }
        [Required]
        [DataType(DataType.Time)] // Specifies that the data type is time
        [Display(Name = "Order Time")]
        public TimeSpan OrderTime { get; set; }
        [Required]  // Ensures that ShippingDate is required and cannot be null
        [DataType(DataType.Date)]  // Specifies that this is a date type, helping with formatting in views
        [Display(Name = "Shipping Date")]  // Custom display name for the property in views
        public DateTime ShippingDate { get; set; }
        [StringLength(100)]  // Limits the length of the string to 100 characters
        [Display(Name = "Transaction Number")]  // Custom display name for UI
        public string TransactionNo { get; set; }  // Nullable string by default
        [DataType(DataType.Date)]  // Specifies that the data type is a date
        [Display(Name = "Transaction Date")]  // Custom display name for UI
        public DateTime? TransactionDate { get; set; }  // Nullable DateTime
        [DataType(DataType.Time)]  // Specifies that the data type is time
        [Display(Name = "Transaction Time")]  // Custom display name for the UI
        public TimeSpan? TransactionTime { get; set; }  // Nullable TimeSpan
        [StringLength(500)]  // Limits the length of the string to 500 characters
        [Display(Name = "Payment Received Snapshot")]  // Custom display name for the property in views
        public string PaymentReceivedSnapshot { get; set; }  // Nullable string by default

    }
}
