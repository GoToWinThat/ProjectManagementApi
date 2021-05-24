using FluentValidation.Results;
using ProjectManagement.Core.Base.Responses;
using ProjectManagement.Core.UseCases.Employees.Dto;

namespace ProjectManagement.Core.UseCases.Employees.Command.CreateEmployee
{
    public class CreateEmployeeCommandResponse : BaseResponse
    {
        public EmployeeDto EmployeeDto { get; set; }
        
        public CreateEmployeeCommandResponse() : base() { }
        public CreateEmployeeCommandResponse(ValidationResult validationResult) : base(validationResult) { }
        public CreateEmployeeCommandResponse(string message) : base(message) { }
        public CreateEmployeeCommandResponse(string message, bool success) : base(message, success) { }
        public CreateEmployeeCommandResponse(EmployeeDto employeeDto) => EmployeeDto = employeeDto;

    }
}
