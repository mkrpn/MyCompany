namespace MyCompanyServices.Models
{
    public class EmployeeListModel
    {
        public IEnumerable<Employee> Employees { get; set; }
        public int TotalCount { get; set; }
    }
}
