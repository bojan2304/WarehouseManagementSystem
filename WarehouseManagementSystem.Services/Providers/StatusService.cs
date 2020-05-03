using System.Collections.Generic;
using System.Linq;
using WarehouseManagementSystem.Data;
using WarehouseManagementSystem.Data.Interfaces;
using WarehouseManagementSystem.Data.Models;

namespace WarehouseManagementSystem.Services.Providers
{
    public class StatusService : IStatusService
    {
        private readonly WmsContext _context;

        public StatusService(WmsContext context)
        {
            _context = context;
        }

        public void Add(Status status)
        {
            _context.Add(status);
            Save();
        }

        public IEnumerable<Status> GetAll()
        {
            return _context.Statuses;
        }

        public Status GetById(int id)
        {
            return GetAll().FirstOrDefault(s => s.Id == id);
        }

        private void Save() => _context.SaveChanges();
    }
}
