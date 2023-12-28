using FluentValidation;
using MediatR;
using MediatRValidationPipeline.Application.Commands.Requests;
using MediatRValidationPipeline.Exceptions;

namespace MediatRValidationPipeline.Application.Commands.Handlers;

public class CreateUserHandler : IRequestHandler<CreateUserCommand>
{
    public async Task Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        // Add user
    }
}