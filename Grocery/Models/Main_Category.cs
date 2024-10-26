using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Grocey.Models
{
    public class Main_Category
    {
        [Key]
        public int Main_CategoryID { get; set; }
        [Required]
        [StringLength(150)]
        public required string MainCategoryTitle { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
        [Required]
        [Column(TypeName = "time(7)")]
        public TimeSpan CreatedTime { get; set; }
    }
}
