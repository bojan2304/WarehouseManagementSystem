using System;
using System.ComponentModel.DataAnnotations;

namespace WarehouseManagementSystem.Data.Models
{
    public class Checkout
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Asset")]
        public WarehouseAsset WarehouseAsset { get; set; }

        [Display(Name = "WE Card")]
        public WarehouseEmployeeCard WarehouseEmployeeCard { get; set; }

        [Display(Name = "Checked Out Since")]
        public DateTime Since { get; set; }

        [Display(Name = "Checked Out Until")]
        public DateTime? Until { get; set; }
    }
}
