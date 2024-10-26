using System.ComponentModel.DataAnnotations;

namespace Online_Grocey.Models
{
    public class SizeType
    {
        [Key]
        public int SizeTypeID { get; set; }
        [Required]
        [StringLength(50)]
        public string? SizeTypee { get; set; }
    }
}
