using FluentResults;

namespace IngressoFacil.Authentication.API.Queries {
    public partial class AuthenticationQueryHandler {
        public async Task<Result<CheckTokenValidityQueryResult>> Handle(CheckTokenValidityQuery query) {

            try {

                var isValid = _tokenService.ValidateToken(query.Token, query.username);
                var isExpired = _tokenService.IsExpiredToken(query.Token);

                return Result.Ok(new CheckTokenValidityQueryResult {
                    IsValid = isValid,
                    IsExpired = isExpired
                });

            } catch (Exception ex) {
                return Result.Fail(ex.Message);
            }
        }
    }
}
