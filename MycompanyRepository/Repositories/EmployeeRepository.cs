using MyCompanyServices.Models;
using System.Linq;

namespace MycompanyRepository.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public IQueryable<Employee> GetAsync(int page, int pageSize)
        {
            throw new NotImplementedException();
        }

        public async Task<int> GetCountAsync(Employee model)
        {
            throw new NotImplementedException();
        }

        public async Task<Employee> AddAsync(Employee model)
        {
            throw new NotImplementedException();
        }
    }
}