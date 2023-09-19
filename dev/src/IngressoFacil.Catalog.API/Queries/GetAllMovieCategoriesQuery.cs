using IngressoFacil.Catalog.API.Models;
using System.Linq.Expressions;

namespace IngressoFacil.Catalog.API.Queries {
    public class GetAllMovieCategoriesQuery {
        public Func<MovieCategory, object?>? OrderByExpression { get; set; }
        public void OrderyBy(Expression<Func<MovieCategory, object?>> expression) {
            OrderByExpression = expression.Compile();
        }
    }
}
