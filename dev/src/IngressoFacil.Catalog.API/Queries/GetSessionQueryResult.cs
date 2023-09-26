using FluentResults;
using IngressoFacil.Catalog.API.Models;

namespace IngressoFacil.Catalog.API.Queries {
    public class GetSessionQueryResult {
        public bool IsSuccess { get; set; }
        public string? Message { get; set; }
        public Session? Session { get; set; }  
    }
}
