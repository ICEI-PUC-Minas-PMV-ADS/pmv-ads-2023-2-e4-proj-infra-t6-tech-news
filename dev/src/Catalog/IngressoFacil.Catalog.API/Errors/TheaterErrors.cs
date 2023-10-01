using FluentResults;

namespace IngressoFacil.Catalog.API.Errors {
    public class TheaterNumberIsNegativeError : Error 
    {

    public TheaterNumberIsNegativeError(int RoomIsNegative) : base($"O número da sala {RoomIsNegative} não pode ser negativo.") { }

    }

    public class TheaterNotFoundError : Error 
    {

    public TheaterNotFoundError() : base($"A sala não pode ser encontrada.") { }
    }

    public class TheaterAlreadyExistsError : Error 
    {
        public TheaterAlreadyExistsError(int RoomNumberAlreadyExists) : base($"A sala de número {RoomNumberAlreadyExists} já existe.") { }
    }
}
