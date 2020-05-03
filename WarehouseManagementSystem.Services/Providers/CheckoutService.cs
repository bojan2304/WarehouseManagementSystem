using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WarehouseManagementSystem.Data;
using WarehouseManagementSystem.Data.Interfaces;
using WarehouseManagementSystem.Data.Models;

namespace WarehouseManagementSystem.Services.Providers
{
    public class CheckoutService : ICheckoutService
    {
        private readonly WmsContext _context;

        public CheckoutService(WmsContext context)
        {
            _context = context;
        }
        public void Add(Checkout checkout)
        {
            _context.Add(checkout);
            Save();
        }

        public void CheckInItem(int id)
        {
            // this is for same time in db
            var now = DateTime.Now;

            var item = _context.WarehouseAssets.FirstOrDefault(a => a.Id == id);
            _context.Update(item);

            var checkout = _context.Checkouts.Include(c => c.WarehouseAsset).Include(c => c.WarehouseEmployeeCard).FirstOrDefault(a => a.WarehouseAsset.Id == id);
            if (checkout != null) _context.Remove(checkout);

            var history = _context.CheckoutHistories.Include(h => h.WarehouseAsset).Include(h => h.WarehouseEmployeeCard).FirstOrDefault(h => h.WarehouseAsset.Id == id && h.CheckedIn == null);
            if (history != null)
            {
                _context.Update(history);
                history.CheckedIn = now;
            }

            item.Status = _context.Statuses.FirstOrDefault(a => a.Name == "Available");

            Save();
        }

        public void CheckOutItem(int id, int warehouseEmployeeCardId)
        {
            if (IsCheckedOut(id)) return;

            var item = _context.WarehouseAssets.Include(a => a.Status).FirstOrDefault(a => a.Id == id);

            _context.Update(item);

            item.Status = _context.Statuses.FirstOrDefault(a => a.Name == "Checked Out");

            //for same time in db
            var now = DateTime.Now;

            var libraryCard = _context.WarehouseEmployeeCards.Include(c => c.Checkouts).FirstOrDefault(a => a.Id == warehouseEmployeeCardId);

            var checkout = new Checkout
            {
                WarehouseAsset = item,
                WarehouseEmployeeCard = libraryCard,
                Since = now
            };

            _context.Add(checkout);

            var checkoutHistory = new CheckoutHistory
            {
                CheckedOut = now,
                WarehouseAsset = item,
                WarehouseEmployeeCard = libraryCard
            };

            _context.Add(checkoutHistory);
            Save();
        }

        public IEnumerable<Checkout> GetAll()
        {
            return _context.Checkouts;
        }

        public Checkout GetById(int id)
        {
            return GetAll().FirstOrDefault(ch => ch.Id == id);
        }

        public IEnumerable<CheckoutHistory> GetCheckoutHistory(int id)
        {
            return _context.CheckoutHistories.Include(a => a.WarehouseAsset).Include(a => a.WarehouseEmployeeCard).Where(a => a.WarehouseEmployeeCard.Id == id);
        }

        public string GetCurrentEmployee(int id)
        {
            var checout = _context.Checkouts.Include(a => a.WarehouseAsset).Include(a => a.WarehouseEmployeeCard).Where(v => v.Id == id);

            var cardId = checout.Include(a => a.WarehouseEmployeeCard).Select(a => a.WarehouseEmployeeCard.Id).FirstOrDefault();

            var employee = _context.Employees.Include(p => p.WarehouseEmployeeCard).First(p => p.WarehouseEmployeeCard.Id == cardId);

            return $"{employee.FirstName} {employee.LastName}";
        }

        public Checkout GetLatestCheckout(int id)
        {
            return _context.Checkouts.Where(c => c.Id == id).OrderByDescending(c => c.Since).FirstOrDefault();
        }

        public int GetQuantity(int id)
        {
            return _context.WarehouseAssets.First(a => a.Id == id).Quantity;
        }

        public bool IsCheckedOut(int id)
        {
            return _context.Checkouts.Any(a => a.WarehouseAsset.Id == id);
        }

        private void Save() => _context.SaveChanges();
    }
}
