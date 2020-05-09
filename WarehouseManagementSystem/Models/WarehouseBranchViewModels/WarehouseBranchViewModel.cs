using System;

namespace WarehouseManagementSystem.Models.WarehouseBranchViewModels
{
    public class WarehouseBranchViewModel
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string Name { get; set; }
        public DateTime OpenDate { get; set; }
        public string Telephone { get; set; }
        public int NumberOfEmployees{ get; set; }
        public int NumberOfAssets { get; set; }
        public decimal TotalAssetValue { get; set; }
        public string ImageUrl { get; set; }
    }
}
