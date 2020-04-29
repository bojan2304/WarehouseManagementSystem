using System;
using System.ComponentModel.DataAnnotations;

namespace WarehouseManagementSystem.Data.Models
{
    public class Material : WarehouseAsset
    {
        [Required]
        public string Manufacturer { get; set; }

        [Required]
        [Display(Name = "EXP")]
        public DateTime ExpirationDate { get; set; }

        [Display(Name = "Description")]
        [StringLength(50, ErrorMessage = "Only 50 characters allowed")]
        public string PurposeShortDescription { get; set; }
    }
}
