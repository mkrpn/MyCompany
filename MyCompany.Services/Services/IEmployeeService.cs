using MyCompany.Repository.Models;
using MyCompany.Services.Models;

namespace MyCompany.Services
{
    public interface IEmployeeService
    {
        Task<Employee> CreateEmployee(Employee model);
        Task<EmployeeListModel> GetAllEmployeesAsync(int page, int pageSize);
    }
}