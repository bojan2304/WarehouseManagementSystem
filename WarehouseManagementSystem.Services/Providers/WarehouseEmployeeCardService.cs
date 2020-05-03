using System.Collections.Generic;
using System.Linq;
using WarehouseManagementSystem.Data;
using WarehouseManagementSystem.Data.Interfaces;
using WarehouseManagementSystem.Data.Models;

namespace WarehouseManagementSystem.Services.Providers
{
    public class WarehouseEmployeeCardService : IWarehouseEmployeeCardService
    {
        private readonly WmsContext _context;

        public WarehouseEmployeeCardService(WmsContext context)
        {
            _context = context;
        }

        public void Add(WarehouseEmployeeCard card)
        {
            _context.Add(card);
            Save();
        }

        public IEnumerable<WarehouseEmployeeCard> GetAll()
        {
            return _context.WarehouseEmployeeCards;
        }

        public WarehouseEmployeeCard GetById(int id)
        {
            return GetAll().FirstOrDefault(c => c.Id == id);
        }

        private void Save() => _context.SaveChanges();
    }
}
