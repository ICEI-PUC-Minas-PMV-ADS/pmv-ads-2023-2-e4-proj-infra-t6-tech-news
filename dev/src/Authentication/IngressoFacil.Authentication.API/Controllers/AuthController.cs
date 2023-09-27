using IngressoFacil.Authentication.API.Commands;
using IngressoFacil.Authentication.API.Queries;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace IngressoFacil.Authentication.API.Controllers {

    [ApiController]
    [Route("v1/[controller]")]
    public class AuthController : ControllerBase {

        private readonly AuthenticationCommandHandler _commandHandler;
        private readonly AuthenticationQueryHandler _queryHandler;
        public AuthController(
            AuthenticationCommandHandler commandHandler,
            AuthenticationQueryHandler queryHandler) {
            _commandHandler = commandHandler;
            _queryHandler = queryHandler;
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] LoginCommand command) {

            var commandResult = await _commandHandler.Handle(command);

            if (commandResult.IsFailed) {
                return NotFound(commandResult.Reasons);
            }

            return Ok(commandResult.Value);
        }

        [HttpPost]
        [Route("cadastre")]
        public async Task<IActionResult> Cadastre([FromBody] CreateUserCommand command) {

            var commandResult = await _commandHandler.Handle(command);

            if (commandResult.IsFailed) {
                return BadRequest(commandResult.Reasons);
            }

            return Ok(commandResult.Value);
        }

        [HttpPost]
        [Route("token/refresh")]
        public async Task<IActionResult> RefreshAsync([FromBody] RefreshTokenCommand command) {

            var commandResult = await _commandHandler.Handle(command);

            if (commandResult.IsFailed) {
                return Unauthorized(commandResult.Reasons);
            }

            return Ok(commandResult.Value);
        }

        [HttpGet]
        [Route("token/check")]
        public async Task<IActionResult> CheckAsync(string username, string token) {

            var query = new CheckTokenValidityQuery { Token = token, username = username };
            var queryResult = await _queryHandler.Handle(query);

            if (queryResult.IsFailed)
            {
                return BadRequest(queryResult.Reasons);
            }

            return Ok(queryResult.Value);
        }

        [HttpPost]
        [Route("confirmation/send")]
        public async Task<IActionResult> SendUserConfirmationAsync([FromBody]SendUserConfirmationCommand command) {

            var commandResult = await _commandHandler.Handle(command);

            if (commandResult.IsFailed) {
                return BadRequest(commandResult.Reasons);
            }

            return Ok();
        }

        [HttpGet]
        [Route("confirmation/{token}")]
        public async Task<IActionResult> ConfirmUserEmailAsync(string token) {

            var command = new ConfirmUserEmailCommand { ConfirmationToken = token };
            var commandResult = await _commandHandler.Handle(command);

            if (commandResult.IsFailed) {
                return BadRequest(commandResult.Reasons);
            }

            return Ok("Email confirmado!!");
        }
    }
}
