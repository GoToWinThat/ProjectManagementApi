using Domain.Entities;
using MediatR;
using ProjectManagement.Core.Base.Mappings;

namespace ProjectManagement.Core.UseCases.ProjectManagers.Commands.CreateProjectManager
{
    public class CreateProjectManagerCommand : IRequest<CreateProjectManagerCommandResponse>, IMapFrom<ProjectManager>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int BossId { get; set; }

        public static void Mapping(MappingProfile profile)
        {
            profile.CreateMap<CreateProjectManagerCommand, ProjectManager>();
        }
    }
}