using System.Collections.Generic;
using WarehouseManagementSystem.Data.Models;

namespace WarehouseManagementSystem.Data.Interfaces
{
    public interface IWarehouseAssetService
    {
        IEnumerable<WarehouseAsset> GetAll();
        WarehouseAsset GetById(int id);
        void Add(WarehouseAsset asset);
        void Edit(WarehouseAsset asset);
        void Delete(int id);
        string GetType(int id);
        string GetName(int id);
        string GetSerialNumber(int id);
        string GetManufacturer(int id);
        string GetExpirationDate(int id);
        string GetWarrantyDate(int id);
        string GetEntyDate(int id);
        WarehouseBranch GetCurrentLocation(int id);
        WarehouseEmployeeCard GetWECardByAssetId(int id);
    }
}
