using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WarehouseManagementSystem.Data;
using WarehouseManagementSystem.Data.Interfaces;
using WarehouseManagementSystem.Data.Models;

namespace WarehouseManagementSystem.Services.Providers
{
    public class ToolService : IToolService
    {
        private readonly WmsContext _context;

        public ToolService(WmsContext context)
        {
            _context = context;
        }

        public void Add(Tool tool)
        {
            _context.Add(tool);
            Save();
        }

        public IEnumerable<Tool> GetAll()
        {
            return _context.Tools;
        }

        public Tool GetById(int id)
        {
            return GetAll().FirstOrDefault(t => t.Id == id);
        }

        public IEnumerable<Tool> GetBySerialNumber(string serial)
        {
            return GetAll().Where(t => t.SerialNumber == serial);
        }

        public IEnumerable<Tool> GetByWarrantyDate(DateTime warrantyDate)
        {
            return GetAll().Where(wd => wd.WarrantyDate == warrantyDate);
        }

        private void Save() => _context.SaveChanges();
    }
}
