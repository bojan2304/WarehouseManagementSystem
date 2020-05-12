using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WarehouseManagementSystem.Data;
using WarehouseManagementSystem.Data.Interfaces;
using WarehouseManagementSystem.Data.Models;

namespace WarehouseManagementSystem.Services.Providers
{
    public class WarehouseAssetService : IWarehouseAssetService
    {
        private readonly WmsContext _context;

        public WarehouseAssetService(WmsContext context)
        {
            _context = context;
        }

        public void Add(WarehouseAsset asset)
        {
            _context.Add(asset);
            Save();
        }

        public void Delete(int id)
        {
            var asset = GetById(id);
            _context.Remove(asset);
            Save();
        }

        public void Edit(WarehouseAsset asset)
        {
            _context.Update(asset);
            Save();
        }

        public IEnumerable<WarehouseAsset> GetAll()
        {
            return _context.WarehouseAssets.Include(a => a.Status).Include(a => a.Location);
        }

        public WarehouseAsset GetById(int id)
        {
            return GetAll().FirstOrDefault(a => a.Id == id);
        }

        public WarehouseBranch GetCurrentLocation(int id)
        {
            return GetById(id).Location;
        }

        public string GetEntyDate(int id)
        {
            return GetById(id).EntryDate.ToString();
        }

        public string GetExpirationDate(int id)
        {
            if (GetType(id) != "Material") return "N/A";
            var material = (Material)GetById(id);
            return material.ExpirationDate.ToString();
        }

        public string GetManufacturer(int id)
        {
            if (GetType(id) != "Material") return "N/A";
            var material = (Material)GetById(id);
            return material.Manufacturer;
        }

        public string GetName(int id)
        {
            return GetById(id).Name;
        }

        public string GetSerialNumber(int id)
        {
            if (GetType(id) != "Tool") return "N/A";
            var tool = (Tool)GetById(id);
            return tool.SerialNumber;
        }

        public string GetType(int id)
        {
            var material = _context.WarehouseAssets.OfType<Material>().FirstOrDefault(a => a.Id == id);
            return material != null ? "Material" : "Tool";
        }

        public string GetWarrantyDate(int id)
        {
            if (GetType(id) != "Tool") return "N/A";
            var tool = (Tool)GetById(id);
            return tool.WarrantyDate.ToString();
        }

        public WarehouseEmployeeCard GetWECardByAssetId(int id)
        {
            return _context.WarehouseEmployeeCards.FirstOrDefault(c => c.Checkouts.Select(a => a.WarehouseAsset).Select(v => v.Id).Contains(id));
        }

        private void Save() => _context.SaveChanges();
    }
}
