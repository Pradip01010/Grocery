using System.ComponentModel.DataAnnotations;

namespace Online_Grocey.Models
{
    public class SizeLevel
    {
        [Key]
        public int SizeLevelID { get; set; }
        [Required]
        [StringLength(50)]
        public string SizeLevell { get; set; }
    }
}