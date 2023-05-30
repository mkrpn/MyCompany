using MyCompanyServices.Models;

namespace MyCompanyServices.Services
{
    public interface IEmployeeService
    {
        Task<Employee> CreateEmployee(Employee model);
        Task<EmployeeListModel> GetAllEmployeesAsync(int page, int pageSize);
    }
}