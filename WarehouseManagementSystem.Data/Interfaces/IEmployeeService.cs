﻿using System.Collections.Generic;
using WarehouseManagementSystem.Data.Models;

namespace WarehouseManagementSystem.Data.Interfaces
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetAll();
        Employee GetById(int id);
        void Add(Employee employee);
        IEnumerable<CheckoutHistory> GetCheckoutHistory(int id);
        IEnumerable<Checkout> GetCheckouts(int id);
    }
}
