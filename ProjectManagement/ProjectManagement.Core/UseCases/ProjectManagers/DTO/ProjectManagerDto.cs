using AutoMapper;
using Domain.Entities;
using ProjectManagement.Core.Base.Mappings;

namespace ProjectManagement.Core.UseCases.ProjectManagers.DTO
{
    public class ProjectManagerDto : IMapFrom<ProjectManager>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public void Mapping(MappingProfile profile)
        {
            profile.CreateMap<ProjectManager, ProjectManagerDto>().ReverseMap();
        }
    }
}