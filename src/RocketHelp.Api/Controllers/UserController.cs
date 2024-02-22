using MediatR;
using Microsoft.AspNetCore.Mvc;
using RocketHelp.Application.UserCases.User.AuthenticateUser;
using RocketHelp.Application.UserCases.User.CreateUser;

namespace RocketHelp.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly IMediator _mediator;

    public UserController(IMediator mediator)
    {
        _mediator = mediator;
    }

    
    [HttpPost]
    [ProducesResponseType(typeof(CreateUserOutput), StatusCodes.Status201Created)]
    public async Task<IActionResult> Create(
        [FromBody] CreateUserInput input,
        CancellationToken cancellationToken
    )
    {
        var output = await _mediator.Send(input, cancellationToken);

        return CreatedAtAction(
            nameof(Create),
            new { output.Id },
            output
        );
    }
}
