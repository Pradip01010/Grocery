using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Online_Grocey.Models
{
    public class UserAddress
    {
        [Key] // Marks this property as the Primary Key
        /*[ForeignKey("AnotherTable")] // Indicates this is also a Foreign Key to another table */
        public int UserAddressID { get; set; }

        // Navigation property for the related entity
        //public AnotherTable? AnotherTable { get; set; }
        [ForeignKey("AddressType")]
        public int AddressTypeID { get; set; }
        [Required]
        [StringLength(10)]
        [RegularExpression(@"^\d{5}(-\d{4})?$", ErrorMessage = "Invalid postal code format.")]
        public string? PostalCode { get; set; }
        [Required]
        [StringLength(20)]
        [RegularExpression(@"^[A-Z0-9-]+$", ErrorMessage = "Invalid contract number format.")]
        public string? ContractNo { get; set; }
    }
}
