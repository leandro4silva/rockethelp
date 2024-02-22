using MediatR;
using Microsoft.AspNetCore.Mvc;
using RocketHelp.Application.UserCases.User.AuthenticateUser;

namespace RocketHelp.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthController : ControllerBase
{
    private readonly IMediator _mediator;

    public AuthController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    [ProducesResponseType(typeof(AuthenticateUserOutput), StatusCodes.Status200OK)]
    public async Task<IActionResult> Authenticate(
        [FromBody] AuthenticateUserInput input,
        CancellationToken cancellationToken
    )
    {
        var output = await _mediator.Send(
            input,
            cancellationToken
        );

        return Ok(output);
    }
}
