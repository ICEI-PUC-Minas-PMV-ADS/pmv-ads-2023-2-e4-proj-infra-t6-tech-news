using IngressoFacil.Catalog.API.Commands;
using IngressoFacil.Catalog.API.Queries;
using IngressoFacil.Catalog.API.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace IngressoFacil.Catalog.API.Controllers {

    [ApiController]
    [Route("v1/[controller]")]
    public class CategoryController : ControllerBase {

        private readonly MovieCategoryRepository _repository;
        private readonly MovieCategoryQueryHandler _queryHandler;
        private readonly MovieCategoryCommandHandler _commandHandler;
        public CategoryController(
            MovieCategoryRepository repository,
            MovieCategoryQueryHandler queryHandler,
            MovieCategoryCommandHandler commandHandler) {

            _repository = repository;
            _queryHandler = queryHandler;
            _commandHandler = commandHandler;
        }

        [HttpGet]
        public async Task<IActionResult> Index(Guid id) {

            var query = new GetMovieCategoryQuery(id);
            var queryResult = await _queryHandler.Handle(query);

            if (!queryResult.IsSuccess) {
                return NotFound(queryResult.Message);
            }

            return Ok(queryResult.Category);
        }

        [HttpGet]
        [Route("all")]
        public async Task<IActionResult> Categories() {

            var query = new GetAllMovieCategoriesQuery();
            query.OrderyBy(cat => cat.Name);
            var queryResult = await _queryHandler.Handle(query);

            if (!queryResult.IsSuccess) {
                return BadRequest(queryResult.Message);
            }

            return Ok(queryResult.Categories);
        }
    }
}
