using System.ComponentModel.DataAnnotations;

namespace Online_Grocey.Models
{
    public class UserType
    {
        [Key]
        public int UserTypeID { get; set; }
        [Required]
        [StringLength(100)]
        public string? UserTypee { get; set; }
    }
}
