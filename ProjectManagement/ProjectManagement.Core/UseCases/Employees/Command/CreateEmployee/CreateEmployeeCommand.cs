using Domain.Entities;
using MediatR;
using ProjectManagement.Core.Base.Mappings;

namespace ProjectManagement.Core.UseCases.Employees.Command.CreateEmployee
{
    public class CreateEmployeeCommand : IRequest<CreateEmployeeCommandResponse>, IMapFrom<Employee>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public int AssignId { get; set; }

        public static void Mapping(MappingProfile profile)
        {
            profile.CreateMap<CreateEmployeeCommand, Employee>();
        }
    }
}
