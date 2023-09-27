namespace IngressoFacil.Catalog.API.Queries {
    public partial class MovieCategoryQueryHandler {
        public async Task<GetMovieCategoryQueryResult> Handle(GetMovieCategoryQuery query) {

            var getResult = await _repository.GetById(query.Id);

            if (getResult.IsFailed) {
                return new GetMovieCategoryQueryResult {
                    IsSuccess = false,
                    Message = getResult.Errors[0].Message
                };
            }

            return new GetMovieCategoryQueryResult {
                IsSuccess = true,
                Category = getResult.Value
            };
        }
    }
}
