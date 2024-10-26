using System.ComponentModel.DataAnnotations;

namespace Online_Grocey.Models
{
    public class Season
    {
        [Key]
        public int SeasonID { get; set; }
        [Required]
        [StringLength(500)]
        public string? SeasonTitle { get; set; }
        [Required] // Ensures the property is not nullable
        [DataType(DataType.Date)] // Specifies the data type for HTML input elements
        public DateTime SeasonStartDate { get; set; }
        [Required] // Ensures the property is not nullable
        [DataType(DataType.Date)] // Specifies the data type for HTML input elements
        public DateTime SeasonEndDate { get; set; }
    }
}
