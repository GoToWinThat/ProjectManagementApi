using FluentValidation;

namespace ProjectManagement.Core.UseCases.ProjectManagers.Commands.CreateProjectManager
{
    public class CreateProjectManagerCommandValidator : AbstractValidator<CreateProjectManagerCommand>
    {
        public CreateProjectManagerCommandValidator()
        {
            RuleFor(c => c.Name).NotEmpty();

            RuleFor(c => c.Surname).NotEmpty();

            RuleFor(c => c.Email).EmailAddress();

            RuleFor(c => c.PhoneNumber).NotEmpty();
            
            RuleFor(c => c.BossId)
                .GreaterThan(0)
                .WithMessage("Id must be more than zero");
        }
    }
}