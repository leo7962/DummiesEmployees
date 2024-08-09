using DummiesEmployees.Server.BusinessLogic;
using DummiesEmployees.Server.DataAccess;
using Microsoft.AspNetCore.Mvc;

namespace DummiesEmployees.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly EmployeeService employeeService;
        private readonly EmployeeManager employeeManager;

        public EmployeesController(EmployeeService employeeService, EmployeeManager employeeManager)
        {
            this.employeeService = employeeService;
            this.employeeManager = employeeManager;
        }

        [HttpGet("employees")]
        public async Task<IActionResult> GetEmployees()
        {
            try
            {
                var employees = await employeeService.GetEmployeesAsync();
                if (employees == null)
                {
                    return StatusCode(500, "Error fetching employee data.");
                }

                return Ok(employees);
            }
            catch (Exception ex)
            {

                return StatusCode(500, "Internal server error.");
            }

        }

        [HttpGet("employee/{id:int}")]
        public async Task<IActionResult> GetEmployee(int id)
        {
            if (id <= 0)
            {
                return BadRequest("Invalid employee ID.");
            }

            try
            {
                var employee = await employeeService.GetEmployeeByIdAsync(id);
                if (employee == null)
                {
                    return NotFound("Employee not found.");
                }

                return Ok(employee);
            }
            catch (Exception ex)
            {

                return StatusCode(500, "Internal server error");
            }

        }
    }
}