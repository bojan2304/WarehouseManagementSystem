using System;
using System.Collections.Generic;
using WarehouseManagementSystem.Data.Models;

namespace WarehouseManagementSystem.Data.Interfaces
{
    public interface IToolService
    {
        IEnumerable<Tool> GetAll();
        Tool GetById(int id);
        IEnumerable<Tool> GetBySerialNumber(string serial);
        IEnumerable<Tool> GetByWarrantyDate(DateTime warrantyDate);
        void Add(Tool tool);
    }
}
