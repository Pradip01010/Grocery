using System.ComponentModel.DataAnnotations;

namespace Online_Grocey.Models
{
    public class Tag
    {
        [Key]
        public int TagID { get; set; }
        [Required]
        [StringLength(150)]
        public string? TagTitle { get; set; }
    }
}
