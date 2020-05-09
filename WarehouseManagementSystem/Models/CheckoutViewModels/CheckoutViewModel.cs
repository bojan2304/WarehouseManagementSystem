using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WarehouseManagementSystem.Models.CheckoutViewModels
{
    public class CheckoutViewModel
    {
        public string WECardId { get; set; }
        public string Name { get; set; }
        public int AssetId { get; set; }
        public string ImageUrl { get; set; }
        public bool IsCheckedOut { get; set; }
    }
}
