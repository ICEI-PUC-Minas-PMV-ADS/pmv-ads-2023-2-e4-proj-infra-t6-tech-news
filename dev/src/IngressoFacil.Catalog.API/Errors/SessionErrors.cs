using FluentResults;

namespace IngressoFacil.Catalog.API.Errors {
    public class SessionStartTimeIsNotValidError : Error {
        public SessionStartTimeIsNotValidError() : base() { }
    } 

    public class SessionNotFoundError : Error {

    }

    public class SessionDateBeforeTodayError : Error {

    }
}
