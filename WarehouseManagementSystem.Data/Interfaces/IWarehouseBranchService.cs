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
        WarehouseBranch GetByName(string name);
        void Add(WarehouseBranch branch);
        void Edit(WarehouseBranch branch);
        void Delete(int id);
        int GetAssetCount(int id);
        int GetEmployeeCount(int id);
        decimal GetAssetsValue(int id);
    }
}
