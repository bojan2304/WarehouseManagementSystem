using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using WarehouseManagementSystem.Data.Interfaces;
using WarehouseManagementSystem.Data.Models;
using WarehouseManagementSystem.Models.EmployeeViewModels;

namespace WarehouseManagementSystem.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;
        private readonly IWarehouseEmployeeCardService _warehouseEmployeeCardService;
        private readonly IWarehouseBranchService _warehouseBranchService;

        public EmployeeController(IEmployeeService employeeService, IWarehouseEmployeeCardService warehouseEmployeeCardService, IWarehouseBranchService warehouseBranchService)
        {
            _employeeService = employeeService;
            _warehouseEmployeeCardService = warehouseEmployeeCardService;
            _warehouseBranchService = warehouseBranchService;
        }

        //GET: Employee/Index
        [HttpGet]
        public IActionResult Index()
        {
            var allEmployees = _employeeService.GetAll();
            var model = allEmployees.Select(e => new EmployeeViewModel
            {
                Id = e.Id,
                FirstName = e.FirstName ?? "No First Name Provided",
                LastName = e.LastName ?? "No Last Name Provided",
                WarehouseEmployeeCardId = e.WarehouseEmployeeCard.Id,
                HomeWarehouse = e.HomeWarehouseBranch?.Name
            }).ToList();

            return View(model);
        }

        //GET: Employee/Detail/{id}
        [HttpGet]
        public IActionResult Detail(int id)
        {
            var employee = _employeeService.GetById(id);
            var model = new EmployeeViewModel
            {
                Id = employee.Id,
                FirstName = employee.FirstName ?? "No First Name Provided",
                LastName = employee.LastName ?? "No Last Name Provided",
                WarehouseEmployeeCardId = employee.WarehouseEmployeeCard.Id,
                Address = employee.Address ?? "No Address Provided",
                Created = employee.WarehouseEmployeeCard?.Created,
                PhoneNumber = employee.PhoneNumber ?? "No Phone Provided",
                HomeWarehouse = employee.HomeWarehouseBranch?.Name,
                AssetsCheckedOut = _employeeService.GetCheckouts(id).ToList(),
                CheckoutHistory = _employeeService.GetCheckoutHistory(id),
            };
            return View(model);
        }

        //GET: Employee/Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        //POST: Employee/Create
        [HttpPost]
        public IActionResult Create(EmployeeViewModel employeVM)
        {
            if (ModelState.IsValid)
            {
                var card = new WarehouseEmployeeCard
                {
                    Created = DateTime.Now
                };
                var model = new Employee
                {
                    FirstName = employeVM.FirstName,
                    LastName = employeVM.LastName,
                    Address = employeVM.Address,
                    PhoneNumber = employeVM.PhoneNumber,
                    WarehouseEmployeeCard = card,
                    HomeWarehouseBranch = _warehouseBranchService.GetByName(employeVM.HomeWarehouse)
                };
                _employeeService.Add(model);
                return RedirectToAction("Index");
            }
            return View();
        }

        //GET: Employee/Edit/{id}
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var employee = _employeeService.GetById(id);
            var model = new EmployeeViewModel
            {
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                Address = employee.Address,
                PhoneNumber = employee.PhoneNumber,
                HomeWarehouse = employee.HomeWarehouseBranch?.Name
            };
            return View(model);
        }

        //POST: Employee/Edit/{id}
        [HttpPost]
        public IActionResult Edit(EmployeeViewModel model)
        {
            if (ModelState.IsValid)
            {
                var employee = _employeeService.GetById(model.Id);

                employee.FirstName = model.FirstName;
                employee.LastName = model.LastName;
                employee.Address = model.Address;
                employee.PhoneNumber = model.PhoneNumber;
                employee.HomeWarehouseBranch = _warehouseBranchService.GetByName(model.HomeWarehouse);

                _employeeService.Edit(employee);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        //GET: Employee/Delete/{id}
        [HttpGet]
        public IActionResult Delete(int id)
        {
            _employeeService.Delete(id);
            
            return RedirectToAction("Index");
        }
    }
}