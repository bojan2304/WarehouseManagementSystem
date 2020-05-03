using System.Collections.Generic;
using WarehouseManagementSystem.Data.Models;

namespace WarehouseManagementSystem.Data.Interfaces
{
    public interface ICheckoutService
    {
        IEnumerable<Checkout> GetAll();
        Checkout GetById(int id);
        void Add(Checkout checkout);
        IEnumerable<CheckoutHistory> GetCheckoutHistory(int id);
        void CheckOutItem(int id, int warehouseEmployeeCardId);
        void CheckInItem(int id);
        Checkout GetLatestCheckout(int id);
        int GetQuantity(int id);
        bool IsCheckedOut(int id);
        string GetCurrentEmployee(int id);
    }
}
