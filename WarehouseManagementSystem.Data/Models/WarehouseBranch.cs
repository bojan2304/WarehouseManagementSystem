using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WarehouseManagementSystem.Data.Models
{
    public class WarehouseBranch
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Limit name to 50 characters")]
        public string Name { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Limit address to 100 characters")]
        public string Address { get; set; }

        [Required]
        public string Telephone { get; set; }

        public DateTime OpenDate { get; set; }

        public string ImageUrl { get; set; }

        public virtual IEnumerable<Employee> Employees { get; set; }

        public virtual IEnumerable<WarehouseAsset> WarehouseAssets { get; set; }
    }
}
