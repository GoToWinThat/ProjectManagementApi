using FluentValidation.Results;
using ProjectManagement.Core.Base.Responses;
using ProjectManagement.Core.UseCases.ProjectManagers.DTO;

namespace ProjectManagement.Core.UseCases.ProjectManagers.Commands.CreateProjectManager
{
    public class CreateProjectManagerCommandResponse : BaseResponse
    {
        public DetailedProjectManagerDto DetailedProjectManagerDto { get; set; }

        public CreateProjectManagerCommandResponse() : base() { }
        public CreateProjectManagerCommandResponse(ValidationResult validationResult) : base(validationResult) { }
        public CreateProjectManagerCommandResponse(string message) : base(message) { }
        public CreateProjectManagerCommandResponse(string message, bool success) : base(message, success) { }
        public CreateProjectManagerCommandResponse(DetailedProjectManagerDto detailedProjectManagerDto) => DetailedProjectManagerDto = detailedProjectManagerDto;
    }
}