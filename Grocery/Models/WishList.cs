using System.ComponentModel.DataAnnotations;

namespace Online_Grocey.Models
{
    public class WishList
    {
        [Key]
        public int WishListID { get; set; }
        [Required]
        public DateTime AddDate { get; set; }
    }
}
