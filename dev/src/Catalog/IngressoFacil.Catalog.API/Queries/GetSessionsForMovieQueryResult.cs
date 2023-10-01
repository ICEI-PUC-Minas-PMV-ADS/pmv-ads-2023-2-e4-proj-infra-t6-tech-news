using IngressoFacil.Catalog.API.Models;

namespace IngressoFacil.Catalog.API.Queries
{
    public class GetSessionsForMovieQueryResult //Indicando que o resultado da consulta será uma lista de sessões
    {
        public IEnumerable<Session> Sessions { get; set; }  
    }
}
