using System.ComponentModel.DataAnnotations;

namespace Online_Grocey.Models
{
    public class ColorType
    {
        [Key]
        public int ColorTypeID { get; set; }
        [Required]
        [StringLength(50)]
        public required string ColorTypee { get; set; }
        [Required]
        [StringLength(50)]
        public string ColorCode { get; set; }
    }
}
