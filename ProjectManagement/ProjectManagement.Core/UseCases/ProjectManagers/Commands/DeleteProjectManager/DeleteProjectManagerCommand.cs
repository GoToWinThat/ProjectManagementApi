using MediatR;

namespace ProjectManagement.Core.UseCases.ProjectManagers.Commands.DeleteProjectManager
{
    public class DeleteProjectManagerCommand : IRequest
    {
        public int ProjectManagerId { get; set; }
    }
}