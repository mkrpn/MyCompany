using MyCompanyServices.Models;

namespace MycompanyRepository.Repositories
{
    public interface IEmployeeRepository
    {
        Task<Employee> AddAsync(Employee model);
        IQueryable<Employee> GetAsync(int page, int pageSize);
        Task<int> GetCountAsync();
    }
}