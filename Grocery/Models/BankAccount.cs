using System.ComponentModel.DataAnnotations;

namespace Online_Grocey.Models
{
    public class BankAccount
    {
        [Key]
        public int BankAccountID { get; set; }
        [Required]
        [StringLength(500)]
        public required string BankName { get; set; }
        [Required]
        [StringLength(500)]
        public required string AccountTitle { get; set; }
        [Required]
        [StringLength(100)]
        public required string AccountNo { get; set; }
        [Required]
        [StringLength(100)]
        public string? IBanNo { get; set; }
    }
}

