using FluentValidation;
using SchoolsAdministrator.Core.Entities;

namespace SchoolsAdministrator.Services.Validators
{
    public class ClassroomValidator : AbstractValidator<Classroom>
    {
        public ClassroomValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .MaximumLength(255);

            RuleFor(x => x.SchoolId)
                .NotEmpty()
                .WithMessage("Classroom MUST have a SchoolId");

        }
    }
}
