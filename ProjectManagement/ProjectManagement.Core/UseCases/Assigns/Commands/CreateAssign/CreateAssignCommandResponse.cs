using FluentValidation.Results;
using ProjectManagement.Core.Base.Responses;
using ProjectManagement.Core.UseCases.Assigns.Dto;

namespace ProjectManagement.Core.UseCases.Assigns.Commands.CreateAssign
{
    public class CreateAssignCommandResponse : BaseResponse
    {
        public AssignDto AssignDto { get; set; }

        public CreateAssignCommandResponse() : base() { }
        public CreateAssignCommandResponse(ValidationResult validationResult) : base(validationResult) { }
        public CreateAssignCommandResponse(string message) : base(message) { }
        public CreateAssignCommandResponse(string message, bool success) : base(message, success) { }
        public CreateAssignCommandResponse(AssignDto assignDto) => AssignDto = assignDto;

    }
}
