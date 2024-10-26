using System.ComponentModel.DataAnnotations;

namespace Online_Grocey.Models
{
    public class Country
    {
        [Key]
        public int CountryID { get; set; }
        [Required]
        [StringLength(100)]
        public required string CountryTitle { get; set; }
    }
}
