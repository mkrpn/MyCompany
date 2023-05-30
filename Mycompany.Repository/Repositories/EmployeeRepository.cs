using MyCompany.Repository.Models;

namespace MyCompany.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public IQueryable<Employee> GetAsync(int page, int pageSize)
        {
            throw new NotImplementedException();
        }

        public async Task<int> GetCountAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Employee> AddAsync(Employee model)
        {
            throw new NotImplementedException();
        }
    }
}