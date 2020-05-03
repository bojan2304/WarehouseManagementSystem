using System;
using System.Collections.Generic;
using System.Text;
using WarehouseManagementSystem.Data.Models;

namespace WarehouseManagementSystem.Data.Interfaces
{
    public interface ICheckoutHistory
    {
        IEnumerable<CheckoutHistory> GetAll();
        IEnumerable<CheckoutHistory> GetForAsset(WarehouseAsset asset);
        IEnumerable<CheckoutHistory> GetForCard(WarehouseEmployeeCard card);
        CheckoutHistory Get(int id);
        void Add(CheckoutHistory checkoutHistory);
    }
}
