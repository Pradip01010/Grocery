using System.ComponentModel.DataAnnotations;

namespace Online_Grocey.Models
{
    public class City
    {
        [Key]
        public int CityID { get; set; }
        [Required]
        [StringLength(150)]
        public required string CityTitle { get; set; }
    }
}
