namespace MyCompanyServices.Models
{
    public class Employee 
    { 
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address1 { get; set; }
        public EmployeeType Type { get; set; }
        public EmployeeSalary Salary { get; set; }
    }
}
