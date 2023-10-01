using IngressoFacil.Authentication.API.Services;

namespace IngressoFacil.Authentication.API.Queries {
    public partial class AuthenticationQueryHandler {

        private readonly TokenService _tokenService;
        public AuthenticationQueryHandler(TokenService tokenService) {
            _tokenService = tokenService;
        }
    }
}
