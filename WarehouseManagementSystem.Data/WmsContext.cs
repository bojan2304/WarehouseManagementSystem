using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Drawing;
using WarehouseManagementSystem.Data.Models;

namespace WarehouseManagementSystem.Data
{
    public class WmsContext : DbContext
    {
        public WmsContext(DbContextOptions options) : base(options){ }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<WarehouseEmployeeCard> WarehouseEmployeeCards { get; set; }
        public DbSet<WarehouseBranch> WarehouseBranches { get; set; }
        public DbSet<Checkout> Checkouts { get; set; }
        public DbSet<CheckoutHistory> CheckoutHistories { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Tool> Tools { get; set; }
        public DbSet<WarehouseAsset> WarehouseAssets { get; set; }
        public DbSet<AssetType> AssetTypes { get; set; }
    }
}
