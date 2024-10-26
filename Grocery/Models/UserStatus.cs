
using System.ComponentModel.DataAnnotations;

namespace Online_Grocey.Models
{
    public class UserStatus
    {
        [Key]
        public int UserStatusID { get; set; }
        [Required]
        [StringLength(100)]
        public string? UserStatuss { get; set; }
    }
}