using IngressoFacil.Catalog.API.Queries;
using IngressoFacil.Catalog.API.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace IngressoFacil.Catalog.API.Controllers {

    [ApiController]
    [Route("v1/[controller]")]
    public class SessionController : ControllerBase {
       
        private readonly SessionRepository _repository;
        private readonly SessionQueryHandler _handler;
        public SessionController(SessionRepository repository, SessionQueryHandler handler) {
            _repository = repository;
            _handler = handler;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById(Guid id) {

            var query = new GetSessionQuery { Id = id };
            var queryResult = await _handler.Handle(query);

            if (queryResult.IsSuccess == false) {
                return NotFound();
            }

            return Ok(queryResult.Session);
        }
    }
}
