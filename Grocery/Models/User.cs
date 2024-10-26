using System.ComponentModel.DataAnnotations;

namespace Online_Grocey.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        [Required]
        [StringLength(100)]
        public string? UserName { get; set; }
        [Required]
        [StringLength(250)]
        public string? Password { get; set; }
        [Required]
        [StringLength(150)]
        public string? EmailAddress { get; set; }
        [Required]
        [StringLength(50)]
        public string? FirtName { get; set; }
        [Required]
        [StringLength(50)]
        public string? LastName { get; set; }
        [Required]
        [StringLength(20)]
        public string? ContractNo { get; set; }
    }
}
