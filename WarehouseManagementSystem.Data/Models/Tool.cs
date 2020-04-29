using System;
using System.ComponentModel.DataAnnotations;

namespace WarehouseManagementSystem.Data.Models
{
    public class Tool : WarehouseAsset
    {
        [Required]
        [Display(Name = "S/N")]
        public string SerialNumber { get; set; }
        
        [Required]
        [Display(Name = "Warranty Date")]
        public DateTime WarrantyDate { get; set; }
    }
}
