using FluentResults;

namespace IngressoFacil.Catalog.API.Errors {
    public class SessionStartTimeIsNotValidError : Error {
        public SessionStartTimeIsNotValidError(TimeSpan time) : base($"O tempo de inicio da sessão: {time} não é valido.") { }
    } 

    public class SessionNotFoundError : Error {
        public SessionNotFoundError() : base("A sessão não pode ser encontrada.") { }
    }

    public class SessionDateBeforeTodayError : Error {
        public SessionDateBeforeTodayError(DateOnly date) : base($"A sessão não pode ser criada na data : {date}.") { }
    }

    public class SessionAlreadyExistsError : Error { 
    public SessionAlreadyExistsError(Guid SessionAlreadyExistsNumber) : base($"A sessão {SessionAlreadyExistsNumber} já existe.") { }    
    }
}
