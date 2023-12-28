using FluentValidation;

namespace MediatRValidationPipeline.Application.Commands.Requests.Validations;

public class CreateUserCommandValidation : AbstractValidator<CreateUserCommand>
{
    public CreateUserCommandValidation()
    {
        RuleFor(x => x.Name)
            .NotEmpty()
            .NotNull()
            .MaximumLength(20);

        RuleFor(x => x.Age)
            .GreaterThan((byte)0);
    }   
}