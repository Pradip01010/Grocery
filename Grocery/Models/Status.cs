using System.ComponentModel.DataAnnotations;

namespace Online_Grocey.Models
{
    public class Status
    {
        [Key]
        public int StatusID { get; set; }
        [Required]
        [StringLength(50)]
        public string? Statuss { get; set; }

    }
}
