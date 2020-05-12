using System;
using System.Collections.Generic;
using WarehouseManagementSystem.Data.Models;

namespace WarehouseManagementSystem.Models.WarehouseAssetViewModels
{
    public class WarehouseAssetViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string EntryDate { get; set; }
        public DateTime ManufactureDate { get; set; }
        public string Manufacturer { get; set; }
        public string Expiration { get; set; }
        public string SerialNumber { get; set; }
        public string WarrantyDate { get; set; }
        public decimal Value { get; set; }
        public string Status { get; set; }

        public string ImageUrl { get; set; }
        public string Location { get; set; }
        public string EmployeeName { get; set; }
        public int Quantity { get; set; }
        public Checkout LatestCheckout { get; set; }
        public WarehouseEmployeeCard CurrentAssociatedWECard { get; set; }
        public IEnumerable<CheckoutHistory> CheckoutHistory { get; set; }
    }
}
