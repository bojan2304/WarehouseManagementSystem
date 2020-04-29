using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WarehouseManagementSystem.Data.Models
{
    public class WarehouseEmployeeCard
    {
        public int Id { get; set; }

        [Display(Name = "Card Issued Date")]
        public DateTime Created { get; set; }

        [Display(Name = "Items in Charge")]
        public virtual IEnumerable<Checkout> Checkouts { get; set; }
    }
}
