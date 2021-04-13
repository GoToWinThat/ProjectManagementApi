using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectManagement.Core.UseCases.ProjectManagers.Commands.CreateProjectManager;
using ProjectManagement.Core.UseCases.ProjectManagers.DTO;
using ProjectManagement.Core.UseCases.ProjectManagers.Queries.GetProjectManagers;
using ProjectManagement.Core.UseCases.ProjectManagers.ViewModels;

namespace ProjectManagementApi.Controllers
{
    public class ProjectManagersController : ApiControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<ProjectManagerVm>> GetAllProjectManagers()
        {
            return await Mediator.Send(new GetProjectManagersQuery());
        }

        [HttpPost]
        public async Task<ActionResult<DetailedProjectManagerDto>> AddProjectManager(
            [FromBody] CreateProjectManagerCommand createProjectManagerCommand)
        {
            var result = await Mediator.Send(createProjectManagerCommand);
            return Ok(result.DetailedProjectManagerDto);
        }
    }
}