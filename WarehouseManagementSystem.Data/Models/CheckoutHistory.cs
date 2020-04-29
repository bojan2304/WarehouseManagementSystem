using System;
using System.ComponentModel.DataAnnotations;

namespace WarehouseManagementSystem.Data.Models
{
    public class CheckoutHistory
    {
        public int Id { get; set; }

        [Required]
        public WarehouseAsset WarehouseAsset { get; set; }

        [Required]
        public WarehouseEmployeeCard WarehouseEmployeeCard { get; set; }

        [Required]
        public DateTime CheckedOut { get; set; }

        public DateTime? CheckedIn { get; set; }
    }
}
