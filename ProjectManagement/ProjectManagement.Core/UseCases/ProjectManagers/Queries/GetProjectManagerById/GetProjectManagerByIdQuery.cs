using Domain.Entities;
using MediatR;
using ProjectManagement.Core.UseCases.ProjectManagers.DTO;

namespace ProjectManagement.Core.UseCases.ProjectManagers.Queries.GetProjectManagerById
{
    public class GetProjectManagerByIdQuery : IRequest<DetailedProjectManagerDto>
    {
        public int ProjectManagerId { get; set; }
    }
}