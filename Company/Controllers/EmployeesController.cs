using Microsoft.AspNetCore.Mvc;
using MyCompanyServices.Models;
using MyCompanyServices.Services;

namespace CompanyAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService service;
        private readonly ILogger<EmployeesController> logger;

        public EmployeesController(IEmployeeService service, ILogger<EmployeesController> logger)
        {
            this.service = service;
            this.logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync(int page, int pageSize)
        {
            try
            {
                var employees = await service.GetAllEmployeesAsync(page, pageSize);
                return Ok(employees);
            }
            catch (Exception ex)
            {
                logger.LogError("Getting employee error", ex);
                return BadRequest("Error occured while getting Employees list");
            }
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(Employee model)
        {
            try
            {
                var employee = await service.CreateEmployee(model);
                return Ok(employee);
            }
            catch (Exception ex)
            {
                logger.LogError("Creating employee error", ex);
                return BadRequest("Error occured while creating Employees");
            }
        }
    }
}