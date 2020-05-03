using System.Collections.Generic;
using WarehouseManagementSystem.Data.Models;

namespace WarehouseManagementSystem.Data.Interfaces
{
    public interface IWarehouseEmployeeCardService
    {
        IEnumerable<WarehouseEmployeeCard> GetAll();
        WarehouseEmployeeCard GetById(int id);
        void Add(WarehouseEmployeeCard card);
    }
}
