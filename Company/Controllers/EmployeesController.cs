using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
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
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(EmployeeListModel))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
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
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Employee))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> PostAsync([BindRequired]Employee model)
        {
            //TODO: Add properties validation for Employee

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