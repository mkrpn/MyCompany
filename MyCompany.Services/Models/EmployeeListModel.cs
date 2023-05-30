using MyCompany.Repository.Models;

namespace MyCompany.Services.Models
{
    public class EmployeeListModel
    {
        public IEnumerable<Employee> Employees { get; set; }
        public int TotalCount { get; set; }
    }
}
