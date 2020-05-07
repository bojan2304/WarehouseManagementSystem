using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WarehouseManagementSystem.Data;
using WarehouseManagementSystem.Data.Interfaces;
using WarehouseManagementSystem.Data.Models;

namespace WarehouseManagementSystem.Services.Providers
{
    public class WarehouseBranchService : IWarehouseBranchService
    {
        private readonly WmsContext _context;

        public WarehouseBranchService(WmsContext context)
        {
            _context = context;
        }

        public void Add(WarehouseBranch branch)
        {
            _context.Add(branch);
            Save();
        }

        public IEnumerable<WarehouseBranch> GetAll()
        {
            return _context.WarehouseBranches.Include(a => a.Employees).Include(a => a.WarehouseAssets);
        }

        public int GetAssetCount(int id)
        {
            return GetById(id).WarehouseAssets.Count();
        }

        public IEnumerable<WarehouseAsset> GetAssets(int id)
        {
            return _context.WarehouseBranches.Include(a => a.WarehouseAssets).FirstOrDefault(b => b.Id == id).WarehouseAssets;
        }

        public decimal GetAssetsValue(int id)
        {
            return GetAssets(id).Select(a => a.Value).Sum();
        }

        public WarehouseBranch GetById(int id)
        {
            return GetAll().FirstOrDefault(b => b.Id == id);
        }

        public WarehouseBranch GetByName(string name)
        {
            return GetAll().FirstOrDefault(b => b.Name == name);
        }

        public int GetEmployeeCount(int id)
        {
            return GetById(id).Employees.Count();
        }

        public IEnumerable<Employee> GetEmployees(int id)
        {
            return _context.WarehouseBranches.Include(a => a.Employees).FirstOrDefault(b => b.Id == id).Employees;
        }

        private void Save() => _context.SaveChanges();
    }
}
