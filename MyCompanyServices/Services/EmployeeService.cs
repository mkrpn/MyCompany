﻿using MycompanyRepository.Repositories;
using MyCompanyServices.Models;

namespace MyCompanyServices.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        public async Task<EmployeeListModel> GetAllEmployeesAsync(int page, int pageSize)
        {
            var employeesList = employeeRepository.GetAsync(page, pageSize).AsEnumerable();
            var employeesTotal = await employeeRepository.GetCountAsync();

            return new EmployeeListModel
            {
                Employees = employeesList,
                TotalCount = employeesTotal
            };
        }

        public Task<Employee> CreateEmployee(Employee model) =>
            employeeRepository.AddAsync(model);
    }
}
