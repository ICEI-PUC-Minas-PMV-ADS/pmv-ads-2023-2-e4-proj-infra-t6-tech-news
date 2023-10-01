using IngressoFacil.Authentication.API.Builders;
using IngressoFacil.Authentication.API.Repositories;
using IngressoFacil.Authentication.API.Services;

namespace IngressoFacil.Authentication.API.Commands {
    public partial class AuthenticationCommandHandler {
        private readonly UserRepository _userRepository;
        private readonly RefreshTokenRepository _refreshTokenRepository;
        private readonly UserBuilder _userBuilder;
        private readonly TokenService _tokenService;
        private readonly PasswordService _passwordService;
        private readonly EmailService _emailService;
        private readonly ConfirmationTokenService _confirmationTokenService;
        public AuthenticationCommandHandler(
            UserRepository userRepository,
            RefreshTokenRepository refreshTokenRepository,
            UserBuilder userBuilder,
            TokenService tokenService,
            PasswordService passwordService,
            ConfirmationTokenService confirmationTokenService,
            EmailService emailService) {

            _userRepository = userRepository;
            _refreshTokenRepository = refreshTokenRepository;
            _userBuilder = userBuilder;
            _tokenService = tokenService;
            _passwordService = passwordService;
            _confirmationTokenService = confirmationTokenService;
            _emailService = emailService;
        }
    }
}
