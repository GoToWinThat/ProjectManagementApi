using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectManagement.Core.UseCases.Employees.Command.CreateEmployee;
using ProjectManagement.Core.UseCases.Employees.Dto;

namespace ProjectManagementApi.Controllers
{
    public class EmployeesController : ApiControllerBase
    {
        [HttpPost]
        public async Task<ActionResult<EmployeeDto>> AddEmployee([FromBody] CreateEmployeeCommand createEmployeeCommand)
        {
            var result = await Mediator.Send(createEmployeeCommand);
            return Ok(result.EmployeeDto);
        }
    }
}
