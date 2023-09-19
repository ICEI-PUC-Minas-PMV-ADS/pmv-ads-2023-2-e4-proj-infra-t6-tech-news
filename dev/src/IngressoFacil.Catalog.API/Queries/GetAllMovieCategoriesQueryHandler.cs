namespace IngressoFacil.Catalog.API.Queries {
    public partial class MovieCategoryQueryHandler {
        public async Task<GetAllMovieCategoriesQueryResult> Handle(GetAllMovieCategoriesQuery query) {

            var queryResult = await _repository.GetAll();

            if (queryResult.IsFailed) {
                return new GetAllMovieCategoriesQueryResult {
                    IsSuccess = false,
                    Message = queryResult.Errors[0].Message
                };
            }

            var categories = queryResult.Value;

            if (query.OrderByExpression is not null) {
                categories.OrderBy(query.OrderByExpression);
            }

            return new GetAllMovieCategoriesQueryResult {
                IsSuccess = true,
                Categories = queryResult.Value
            };
        }
    }
}
