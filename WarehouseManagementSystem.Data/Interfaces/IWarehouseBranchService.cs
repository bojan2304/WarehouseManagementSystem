using System.Collections.Generic;
using WarehouseManagementSystem.Data.Models;

namespace WarehouseManagementSystem.Data.Interfaces
{
    public interface IWarehouseBranchService
    {
        IEnumerable<WarehouseBranch> GetAll();
        IEnumerable<Employee> GetEmployees(int id);
        IEnumerable<WarehouseAsset> GetAssets(int id);
        WarehouseBranch GetById(int id);
        void Add(WarehouseBranch branch);
        int GetAssetCount(int id);
        int GetEmployeeCount(int id);
        decimal GetAssetsValue(int id);
    }
}
