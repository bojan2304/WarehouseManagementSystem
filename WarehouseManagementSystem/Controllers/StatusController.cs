using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using WarehouseManagementSystem.Data.Interfaces;
using WarehouseManagementSystem.Data.Models;
using WarehouseManagementSystem.Models.StatusViewModels;

namespace WarehouseManagementSystem.Controllers
{
    public class StatusController : Controller
    {
        private readonly IStatusService _statusService;

        public StatusController(IStatusService statusService)
        {
            _statusService = statusService;
        }

        //GET: Status/Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        //POST: Status/Create
        [HttpPost]
        public IActionResult Create(StatusViewModel model)
        {
            if (ModelState.IsValid)
            {
                var status = new Status
                {
                    Name = model.Name,
                    Description = model.Description
                };
                _statusService.Add(status);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        //GET: Status/Index
        [HttpGet]
        public IActionResult Index()
        {
            var model = _statusService.GetAll().Select(s => new StatusViewModel
            {
                Id = s.Id,
                Name = s.Name,
                Description = s.Description
            }).ToList();
            return View(model);
        }

        //GET: Status/Edit/{id}
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var status = _statusService.GetById(id);
            var model = new StatusViewModel
            {
                Id = status.Id,
                Name = status.Name,
                Description = status.Description
            };
            return View(model);
        }

        //POST: Status/Edit/{id}
        [HttpPost]
        public IActionResult Edit(StatusViewModel model)
        {
            if (ModelState.IsValid)
            {
                var status = _statusService.GetById(model.Id);

                status.Name = model.Name;
                status.Description = model.Description;

                _statusService.Edit(status);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        //GET: Status/Delete/{id}
        [HttpGet]
        public IActionResult Delete(int id)
        {
            _statusService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}