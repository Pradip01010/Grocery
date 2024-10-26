using System.ComponentModel.DataAnnotations;

namespace Online_Grocey.Models
{
    public class AddressType
    {
        [Key]
        public int AddressTypeId { get; set; }

        [Required]
        [StringLength(100)]

        public String? AddressTypee { get; set; }
    }
}
