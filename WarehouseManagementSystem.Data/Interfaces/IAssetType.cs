using System.Collections.Generic;
using WarehouseManagementSystem.Data.Models;

namespace WarehouseManagementSystem.Data.Interfaces
{
    public interface IAssetType
    {
        IEnumerable<AssetType> GetAll();
        AssetType GetById(int id);
        void Add(AssetType asset);
    }
}
