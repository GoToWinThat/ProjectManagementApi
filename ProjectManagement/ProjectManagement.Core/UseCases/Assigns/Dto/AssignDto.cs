using System;
using Domain.Entities;
using ProjectManagement.Core.Base.Mappings;

namespace ProjectManagement.Core.UseCases.Assigns.Dto
{
    public class AssignDto : IMapFrom<Assign>
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int TaskId { get; set; }
        
        public int ProjectManagerId { get; set; }
        public ProjectManager ProjectManager { get; set; }
        
        public Role Role { get; set; }
        public Employee Employee { get; set; }

        public static void Mapping(MappingProfile profile)
        {
            profile.CreateMap<Assign, AssignDto>().ReverseMap();
        }
    }
}
