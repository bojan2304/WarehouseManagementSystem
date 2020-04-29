using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WarehouseManagementSystem.Data.Models
{
    public abstract class WarehouseAsset
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Entry Date")]
        public DateTime EntryDate { get; set; }

        [Required]
        [Display(Name = "MFG Date")]
        public DateTime ManufactureDate { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Value { get; set; }

        public string ImageUrl { get; set; }

        public int Quantity { get; set; }

        public virtual WarehouseBranch Location { get; set; }

        [Required]
        public Status Status{ get; set; }
    }
}
