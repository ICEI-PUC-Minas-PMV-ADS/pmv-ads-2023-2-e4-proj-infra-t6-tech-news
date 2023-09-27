using FluentResults;
using IngressoFacil.Authentication.API.Models;
using IngressoFacil.Authentication.API.Errors;
using IngressoFacil.Authentication.API.Services;
using IngressoFacil.Authentication.API.Validations;

namespace IngressoFacil.Authentication.API.Builders
{
    public class UserBuilder {

        private Result<User> _result;
        private User _user;
        private readonly PasswordService _passwordService;
        public UserBuilder(PasswordService passwordService) {
            _passwordService = passwordService;
        }
        public UserBuilder CreateNew() {
            _result = new Result<User>();
            _user = new User();

            return this;
        }
        public UserBuilder WithEmail(string email) {

            if (_result is null || _user is null) {
                throw new InvalidOperationException("Call 'CreateNew' method for create a new user.");
            }

            if (email is null) {
                _result.WithError(new ArgumentNullError(nameof(email)));
                return this;
            }

            EmailValidation.Normalize(ref email);

            if (EmailValidation.IsBlank(email)) {
                _result.WithError<EmailIsBlankError>();
                return this;
            }

            if (EmailValidation.IsInvalidEmail(email)) {
                _result.WithError(new EmailIsInvalidError(email));
                return this;
            }
                
            _user.Email = email;
            
            return this;
        }
        public UserBuilder WithPassword(string password) {

            if (_result is null || _user is null) {
                throw new InvalidOperationException("Call 'CreateNew' method for create a new user.");
            }

            if (password is null) {
                _result.WithError(new ArgumentNullError(nameof(password)));
                return this;
            }

            PasswordValidation.Normalize(ref password);

            if (PasswordValidation.IsBlank(password)) {
                _result.WithError<PasswordIsBlankError>();
                return this;
            }

            if (PasswordValidation.IsInvalid(password)) {
                _result.WithError<PasswordIsInvalidError>();
                return this;
            }

            _user.Password = password;

            return this;
        }
        public UserBuilder EncryptPassword() {
            _user.Password = _passwordService.
                EncryptPassword(_user.Password);

            return this;
        }
        public Result<User> Build() {

            if (_result is null || _user is null) {
                throw new InvalidOperationException("Call 'CreateNew' method for create a new user.");
            }

            if (_result.IsSuccess) {
                _result.WithValue(_user);
            }

            return _result;
        }
    }
}
