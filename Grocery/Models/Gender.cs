using System.ComponentModel.DataAnnotations;

namespace Online_Grocey.Models
{
    public class Gender
    {
        [Key]
        public int GenderID { get; set; }
        [Required]
        [StringLength(50)]
        public required string GenderTitle { get; set; }
    }
}
