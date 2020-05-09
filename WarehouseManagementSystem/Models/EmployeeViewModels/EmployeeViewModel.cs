using System;
using System.Collections.Generic;
using WarehouseManagementSystem.Data.Models;

namespace WarehouseManagementSystem.Models.EmployeeViewModels
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int WarehouseEmployeeCardId { get; set; }
        public string Address { get; set; }
        public DateTime? Created { get; set; }
        public string PhoneNumber { get; set; }
        public string HomeWarehouse { get; set; }
        public IEnumerable<Checkout> AssetsCheckedOut { get; set; }
        public IEnumerable<CheckoutHistory> CheckoutHistory { get; set; }
    }
}
