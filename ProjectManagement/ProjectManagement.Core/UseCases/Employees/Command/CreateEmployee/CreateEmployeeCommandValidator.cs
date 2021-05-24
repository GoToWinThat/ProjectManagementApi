using FluentValidation;

namespace ProjectManagement.Core.UseCases.Employees.Command.CreateEmployee
{
    public class CreateEmployeeCommandValidator : AbstractValidator<CreateEmployeeCommand>
    {
        public CreateEmployeeCommandValidator()
        {
            RuleFor(c => c.Name).NotEmpty();

            RuleFor(c => c.Surname).NotEmpty();

            RuleFor(c => c.Email).EmailAddress();

            RuleFor(c => c.PhoneNumber).NotEmpty();
        }
    }
}
