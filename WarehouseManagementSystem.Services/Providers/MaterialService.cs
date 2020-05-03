using System;
using System.Collections.Generic;
using System.Linq;
using WarehouseManagementSystem.Data;
using WarehouseManagementSystem.Data.Interfaces;
using WarehouseManagementSystem.Data.Models;

namespace WarehouseManagementSystem.Services.Providers
{
    public class MaterialService : IMaterialService
    {
        private readonly WmsContext _context;

        public MaterialService(WmsContext context)
        {
            _context = context;
        }

        public void Add(Material material)
        {
            _context.Add(material);
            Save();
        }

        public IEnumerable<Material> GetAll()
        {
            return _context.Materials;
        }

        public IEnumerable<Material> GetByExpirationDate(DateTime dateTime)
        {
            return GetAll().Where(m => m.ExpirationDate == dateTime);
        }

        public Material GetById(int id)
        {
            return GetAll().FirstOrDefault(m => m.Id == id);
        }

        public IEnumerable<Material> GetByManufacturer(string manufacturer)
        {
            return GetAll().Where(m => m.Manufacturer.Contains(manufacturer));
        }

        private void Save() => _context.SaveChanges();
    }
}
