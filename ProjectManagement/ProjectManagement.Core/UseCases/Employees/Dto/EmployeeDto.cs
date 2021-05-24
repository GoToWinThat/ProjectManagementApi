using Domain.Entities;
using ProjectManagement.Core.Base.Mappings;

namespace ProjectManagement.Core.UseCases.Employees.Dto
{
    public class EmployeeDto : IMapFrom<Employee>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public int AssignId { get; set; }

        public static void Mapping(MappingProfile profile)
        {
            profile.CreateMap<Employee, EmployeeDto>();
        }

    }
}
