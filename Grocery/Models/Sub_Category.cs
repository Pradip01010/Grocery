using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Grocey.Models

{
    public class Sub_Category
    {
        [Key]
        public int Sub_CategoryID { get; set; }
        [Required]
        [StringLength(150)]
        public string? Sub_CategoryTitle { get; set; }
        [Required] // Ensures that the date cannot be null
        public DateTime CreatedDate { get; set; }
        [Required]
        [Column(TypeName = "time(7)")]
        public TimeSpan CreatedTime { get; set; }
    }
}