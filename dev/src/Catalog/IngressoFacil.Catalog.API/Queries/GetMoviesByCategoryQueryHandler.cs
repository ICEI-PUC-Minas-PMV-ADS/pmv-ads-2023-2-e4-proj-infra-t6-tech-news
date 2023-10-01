using FluentResults;

namespace IngressoFacil.Catalog.API.Queries
{
    public partial class MovieQueryHandler {
        public async Task<Result<GetMoviesByCategoryQueryResult>> Handle(GetMoviesByCategoryQuery query) 
        {
            try
            {
                var Movies = await repository.GetMoviesByCategory(query.CategoryName);
                return Result.Ok(new GetMoviesByCategoryQueryResult
                {
                    Movies = Movies
                });
                
            }
            catch (Exception ex)
            {
                return Result.Fail(ex.Message);
            }

        }

    }
}
