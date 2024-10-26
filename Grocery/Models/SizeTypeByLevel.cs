using System.ComponentModel.DataAnnotations;

namespace Online_Grocey.Models
{
    public class SizeTypeByLevel
    {
        [Key]
        public int SizeTypeByLevelID { get; set; }
        [Required]
        [StringLength(50)]
        public string? SizeLevelValue { get; set; }
    }
}
