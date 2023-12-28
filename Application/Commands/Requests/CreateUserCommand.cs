using MediatR;

namespace MediatRValidationPipeline.Application.Commands.Requests;

public record CreateUserCommand(string Name, int Age) : IRequest;