using FluentValidation;
using MediatR;
using MediatRValidationPipeline.Application.Commands.Behaviors;
using MediatRValidationPipeline.Application.Commands.Requests;
using MediatRValidationPipeline.Middlewares;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddMediatR(cfg => 
    cfg.RegisterServicesFromAssembly(typeof(Program).Assembly));

builder.Services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));

builder.Services.AddValidatorsFromAssembly(typeof(Program).Assembly);


var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.MapPost("/user", async (CreateUserCommand request , IMediator mediator, CancellationToken cancellationToken) =>
{
    await mediator.Send(request, cancellationToken);
})
.WithName("CreateUser")
.WithOpenApi();

app.UseErrorMiddleware();

app.Run();