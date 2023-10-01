using FluentResults;

namespace IngressoFacil.Catalog.API.Queries
{
    public partial class SessionQueryHandler
    {
        public async Task<Result<GetSessionsForMovieQueryResult>> Handle(GetSessionsForMovieQuery query) {
            try
            {
                var Session = await _repository.GetSessionByMovie(query.MovieId);
                return Result.Ok(new GetSessionsForMovieQueryResult
                {
                    Sessions = Session,
                });
            }
            catch (Exception ex) 
            {
                return Result.Fail(ex.Message);
            }
        }
    }
}
