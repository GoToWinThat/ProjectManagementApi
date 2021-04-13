using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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
    }
}