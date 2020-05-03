using System;
using System.Collections.Generic;
using WarehouseManagementSystem.Data.Models;

namespace WarehouseManagementSystem.Data.Interfaces
{
    public interface IMaterialService
    {
        IEnumerable<Material> GetAll();
        IEnumerable<Material> GetByManufacturer(string manufacturer);
        IEnumerable<Material> GetByExpirationDate(DateTime dateTime);
        Material GetById(int id);
        void Add(Material material);
    }
}
