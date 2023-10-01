using FluentResults;

namespace IngressoFacil.Authentication.API.Errors {
    public class PropertyIsBlankError : Error {
        public PropertyIsBlankError(string property) : base($"A propriedade {property} não pode estar em branco.") { }
    }
    public class PropertyLengthTooLongError : Error {
        public PropertyLengthTooLongError(string property, int maxLength) : base($"A propriedade {property} deve ter no máximo {maxLength} caracteres.") { }
    }
    public class PropertyLengthTooShortError : Error {
        public PropertyLengthTooShortError(string property, int minLength) : base($"A propriedade {property} deve ter no mínimo {minLength} caracteres.") { }
    }
    public class PropertyValueTooLongError : Error {
        public PropertyValueTooLongError(string property, int maxValue) : base($"O Valor da propriedade {property} deve ser no máximo {maxValue}.") { }
    }
    public class PropertyValueTooSmallError : Error {
        public PropertyValueTooSmallError(string property, int minValue) : base($"O Valor da propriedade {property} deve ser no mínimo {minValue}.") { }
    }
}
