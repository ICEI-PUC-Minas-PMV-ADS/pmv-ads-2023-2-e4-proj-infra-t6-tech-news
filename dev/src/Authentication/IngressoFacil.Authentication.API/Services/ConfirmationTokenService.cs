using FluentResults;
using IngressoFacil.Authentication.API.Models;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace IngressoFacil.Authentication.API.Services {
    public class ConfirmationTokenService {

        private readonly JwtSecurityTokenHandler _tokenHandler;
        private readonly TokenValidationParameters _validationParameters;
        private readonly SymmetricSecurityKey _key;
        public ConfirmationTokenService() {

            _key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("eTBtNGh4bHMxNHd2YzE4aTdkZGoyYm5yN2o3cGF3dGNsazFjYjFlM3VmZXRucDlhdW1uMnpxN2RodTYxa3llZ3V1N2JicTU1YWkxMzliczVkMnVqN2NqOHc1bDdlNnFqeTdlMWJ6YXpnZXZ5aDUyODVkN3N3aTdoMzRvYnh2MDk="));
            _tokenHandler = new JwtSecurityTokenHandler();
            _validationParameters = new TokenValidationParameters {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = _key,
                ValidateIssuer = false,
                ValidateAudience = false,
                ClockSkew = TimeSpan.Zero
            };
        }
        public string GenerateConfirmationTokenCode(ConfirmationToken data, int time) {

            var tokenDescriptor = new SecurityTokenDescriptor {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim("username", data.Username),
                    new Claim("type", data.Type.ToString())
                }),
                Expires = DateTime.UtcNow.AddHours(time),
                SigningCredentials = new SigningCredentials(_key, SecurityAlgorithms.HmacSha256Signature)
            };

            var token = _tokenHandler.CreateToken(tokenDescriptor);

            return _tokenHandler.WriteToken(token);
        }
        public Result<ConfirmationToken> ValidateConfirmationTokenCode(string confirmationTokenCode) {

            try {

                var claims = _tokenHandler
                    .ValidateToken(confirmationTokenCode, _validationParameters, out SecurityToken validatedToken);

                var confirmationData = new ConfirmationToken();
                confirmationData.Username = claims.FindFirstValue("username");

                switch(claims.FindFirstValue("type")) {
                    case "EmailConfirmation":
                        confirmationData.Type = ConfirmationType.EmailConfirmation;
                        break;
                }

                return Result.Ok(confirmationData);

            } catch (Exception ex) {
                return Result.Fail(ex.Message);
            }
        }
    }
}
