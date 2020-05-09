using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WarehouseManagementSystem.Data.Interfaces;
using WarehouseManagementSystem.Models.CheckoutViewModels;
using WarehouseManagementSystem.Models.WarehouseAssetViewModels;

namespace WarehouseManagementSystem.Controllers
{
    public class AssetController : Controller
    {
        private readonly IWarehouseAssetService _warehouseAssetService;
        private readonly ICheckoutService _checkoutService;

        public AssetController(IWarehouseAssetService warehouseAssetService, ICheckoutService checkoutService)
        {
            _warehouseAssetService = warehouseAssetService;
            _checkoutService = checkoutService;
        }

        //GET: Asset/Index
        [HttpGet]
        public IActionResult Index()
        {
            var model = _warehouseAssetService.GetAll().Select(a => new WarehouseAssetViewModel
            {
                Id = a.Id,
                ImageUrl = a.ImageUrl,
                Expiration = _warehouseAssetService.GetExpirationDate(a.Id),
                WarrantyDate = _warehouseAssetService.GetWarrantyDate(a.Id),
                Name = _warehouseAssetService.GetName(a.Id),
                Type = _warehouseAssetService.GetType(a.Id),
                Quantity = _checkoutService.GetQuantity(a.Id)
            }).ToList();
            return View(model);
        }

        //GET: Asset/Detail/{id}
        [HttpGet]
        public IActionResult Detail(int id)
        {
            var asset = _warehouseAssetService.GetById(id);
            var model = new WarehouseAssetViewModel
            {
                ImageUrl = asset.ImageUrl,
                Id = asset.Id,
                Name = _warehouseAssetService.GetName(id),
                Type = _warehouseAssetService.GetType(id),
                EntryDate = _warehouseAssetService.GetEntyDate(id),
                Manufacturer = _warehouseAssetService.GetManufacturer(id),
                Expiration = _warehouseAssetService.GetExpirationDate(id),
                WarrantyDate = _warehouseAssetService.GetWarrantyDate(id),
                Location = _warehouseAssetService.GetCurrentLocation(id).Name,
                Quantity = _checkoutService.GetQuantity(id),
                Value = asset.Value,
                EmployeeName = _checkoutService.GetCurrentEmployee(id),
                CurrentAssociatedWECard = _warehouseAssetService.GetWECardByAssetId(id),
                Status = asset.Status.Name,
                CheckoutHistory = _checkoutService.GetCheckoutHistory(id),
                LatestCheckout = _checkoutService.GetLatestCheckout(id)
            };
            return View(model);
        }

        public IActionResult Checkout(int id)
        {
            var asset = _warehouseAssetService.GetById(id);

            var model = new CheckoutViewModel
            {
                AssetId = id,
                ImageUrl = asset.ImageUrl,
                Name = asset.Name,
                WECardId = "",
                IsCheckedOut = _checkoutService.IsCheckedOut(id)
            };
            return View(model);
        }

        public IActionResult CheckIn(int id)
        {
            _checkoutService.CheckInItem(id);
            return RedirectToAction("Detail", new { id });
        }

        [HttpPost]
        public IActionResult PlaceCheckout(int assetId, int cardId)
        {
            _checkoutService.CheckOutItem(assetId, cardId);
            return RedirectToAction("Detail", new { id = assetId });
        }
    }
}