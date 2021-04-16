using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectManagement.Core.UseCases.ProjectManagers.Commands.CreateProjectManager;
using ProjectManagement.Core.UseCases.ProjectManagers.Commands.DeleteProjectManager;
using ProjectManagement.Core.UseCases.ProjectManagers.DTO;
using ProjectManagement.Core.UseCases.ProjectManagers.Queries.GetProjectManagerById;
using ProjectManagement.Core.UseCases.ProjectManagers.Queries.GetProjectManagers;
using ProjectManagement.Core.UseCases.ProjectManagers.ViewModels;
using ProjectManagement.Core.UseCases.Projects.Commands.DeleteProject;

namespace ProjectManagementApi.Controllers
{
    public class ProjectManagersController : ApiControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<ProjectManagerVm>> GetAllProjectManagers()
        {
            return await Mediator.Send(new GetProjectManagersQuery());
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult<DetailedProjectManagerDto>> GetAllProjectManagerById(int id)
        {
            var getProjectManagerByIdQuery = new GetProjectManagerByIdQuery()
            {
                ProjectManagerId = id
            };
            return await Mediator.Send(getProjectManagerByIdQuery);
        }

        [HttpPost]
        public async Task<ActionResult<DetailedProjectManagerDto>> AddProjectManager(
            [FromBody] CreateProjectManagerCommand createProjectManagerCommand)
        {
            var result = await Mediator.Send(createProjectManagerCommand);
            return Ok(result.DetailedProjectManagerDto);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteProjectManager(int id)
        {
            var deleteProjectManagerCommand = new DeleteProjectManagerCommand()
            {
                ProjectManagerId = id
            };
            await Mediator.Send(deleteProjectManagerCommand);
            
            return NoContent();
        }
    }
}