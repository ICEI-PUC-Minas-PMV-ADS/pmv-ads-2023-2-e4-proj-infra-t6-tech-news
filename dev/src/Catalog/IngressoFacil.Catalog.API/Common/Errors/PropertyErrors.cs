using FluentResults;

namespace IngressoFacil.Catalog.API.Common.Errors {
    public class PropertyIsBlankError : Error {
        public PropertyIsBlankError(string property) : base($"The {property} property cannot be blank.") { }
    }
    public class PropertyLengthTooLongError : Error {
        public PropertyLengthTooLongError(string property, int maxLength) : base($"The {property} property must have a maximum of {maxLength} characters.") { }
    }
    public class PropertyLengthTooShortError : Error {
        public PropertyLengthTooShortError(string property, int minLength) : base($"The {property} property must have a minimum of {minLength} characters.") { }
    }
}
