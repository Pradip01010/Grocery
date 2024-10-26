using System.ComponentModel.DataAnnotations;

namespace Online_Grocey.Models
{
    public class Unit
    {
        [Key]
        public int UnitID { get; set; }
        [Required]
        [StringLength(100)]
        public string? UnitTitle { get; set; }
    }
}
