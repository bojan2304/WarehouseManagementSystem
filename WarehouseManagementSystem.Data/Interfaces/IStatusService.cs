using System.Collections.Generic;
using WarehouseManagementSystem.Data.Models;

namespace WarehouseManagementSystem.Data.Interfaces
{
    public interface IStatusService
    {
        IEnumerable<Status> GetAll();
        Status GetById(int id);
        void Add(Status status);
    }
}
