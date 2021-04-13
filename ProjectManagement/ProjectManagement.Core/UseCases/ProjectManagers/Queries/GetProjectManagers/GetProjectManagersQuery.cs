using MediatR;
using ProjectManagement.Core.UseCases.ProjectManagers.ViewModels;

namespace ProjectManagement.Core.UseCases.ProjectManagers.Queries.GetProjectManagers
{
    public class GetProjectManagersQuery : IRequest<ProjectManagerVm> { }
}