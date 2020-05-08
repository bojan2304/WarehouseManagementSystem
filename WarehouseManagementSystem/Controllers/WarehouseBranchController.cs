using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WarehouseManagementSystem.Data.Interfaces;
using WarehouseManagementSystem.Data.Models;
using WarehouseManagementSystem.Models.WarehouseBranchViewModels;

namespace WarehouseManagementSystem.Controllers
{
    public class WarehouseBranchController : Controller
    {
        private readonly IWarehouseBranchService _warehouseBranchService;

        public WarehouseBranchController(IWarehouseBranchService warehouseBranch)
        {
            _warehouseBranchService = warehouseBranch;
        }

        //GET: WarehouseBranch/Index
        [HttpGet]
        public IActionResult Index()
        {
            var model = _warehouseBranchService.GetAll().Select(b => new WarehouseBranchViewModel
            {
                Id = b.Id,
                Name = b.Name,
                NumberOfAssets = _warehouseBranchService.GetAssetCount(b.Id),
                NumberOfEmployees = _warehouseBranchService.GetEmployeeCount(b.Id)
            }).ToList();
            return View(model);
        }

        //GET: WarehouseBranch/Detail/{id}
        [HttpGet]
        public IActionResult Detail(int id)
        {
            var branch = _warehouseBranchService.GetById(id);
            var model = new WarehouseBranchViewModel
            {
                Id = branch.Id,
                Name = branch.Name,
                Address = branch.Address,
                Telephone = branch.Telephone,
                OpenDate = branch.OpenDate,
                ImageUrl = branch.ImageUrl,
                TotalAssetValue = _warehouseBranchService.GetAssetsValue(id),
                NumberOfAssets = _warehouseBranchService.GetAssetCount(branch.Id),
                NumberOfEmployees = _warehouseBranchService.GetEmployeeCount(branch.Id),

            };
            return View(model);
        }

        //GET: WarehoseBranch/Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        //POST: WarehoseBranch/Create
        [HttpPost]
        public IActionResult Create(WarehouseBranchViewModel model)
        {
            if (ModelState.IsValid)
            {
                var branch = new WarehouseBranch
                {
                    Id = model.Id,
                    Name = model.Name,
                    Address = model.Address,
                    Telephone = model.Telephone,
                    OpenDate = model.OpenDate,
                    ImageUrl = model.ImageUrl
                };
                _warehouseBranchService.Add(branch);
                return RedirectToAction("Index");
            }
            return View();
        }

        //GET: WarehouseBranch/Edit/{id}
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var branch = _warehouseBranchService.GetById(id);
            var model = new WarehouseBranchViewModel
            {
                Name = branch.Name,
                Address = branch.Address,
                Telephone = branch.Telephone,
                OpenDate = branch.OpenDate,
                ImageUrl = branch.ImageUrl
            };
            return View(model);
        }

        //POST: WarehouseBranch/Edit/{id}
        [HttpPost]
        public IActionResult Edit(WarehouseBranchViewModel model)
        {
            var branch = _warehouseBranchService.GetById(model.Id);

            branch.Name = model.Name;
            branch.Address = model.Address;
            branch.Telephone = model.Telephone;
            branch.OpenDate = model.OpenDate;
            branch.ImageUrl = model.ImageUrl;

            _warehouseBranchService.Edit(branch);
            return RedirectToAction("Index");
        }

        //GET: WarehouseBranch/Delete/{id}
        [HttpGet]
        public IActionResult Delete(int id)
        {
            _warehouseBranchService.Delete(id);

            return RedirectToAction("Index");
        }
    }
}