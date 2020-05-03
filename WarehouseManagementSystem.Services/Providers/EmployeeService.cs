using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WarehouseManagementSystem.Data;
using WarehouseManagementSystem.Data.Interfaces;
using WarehouseManagementSystem.Data.Models;

namespace WarehouseManagementSystem.Services.Providers
{
    public class EmployeeService : IEmployeeService
    {
        private readonly WmsContext _context;

        public EmployeeService(WmsContext context)
        {
            _context = context;
        }

        public void Add(Employee employee)
        {
            _context.Add(employee);
            Save();
        }

        public IEnumerable<Employee> GetAll()
        {
            return _context.Employees.Include(a => a.WarehouseEmployeeCard).Include(a => a.HomeWarehouseBranch);
        }

        public Employee GetById(int id)
        {
            return GetAll().FirstOrDefault(e => e.Id == id);
        }

        public IEnumerable<CheckoutHistory> GetCheckoutHistory(int id)
        {
            var cardId = _context.Employees.Include(a => a.WarehouseEmployeeCard).FirstOrDefault(a => a.Id == id)?.WarehouseEmployeeCard.Id;

            return _context.CheckoutHistories.Include(a => a.WarehouseEmployeeCard).Include(a => a.WarehouseAsset).Where(a => a.WarehouseEmployeeCard.Id == cardId).OrderByDescending(a => a.CheckedOut);
        }

        public IEnumerable<Checkout> GetCheckouts(int id)
        {
            var employeeCardId = GetById(id).WarehouseEmployeeCard.Id;
            return _context.Checkouts.Include(a => a.WarehouseEmployeeCard).Include(a => a.WarehouseAsset).Where(v => v.WarehouseEmployeeCard.Id == employeeCardId);
        }

        private void Save() => _context.SaveChanges();
    }
}
