using Teste_Xbits.Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Teste_Xbits.Infra.Interfaces.RepositoryContracts;

public interface IProductRepository : IDisposable
{
    Task<Product> SaveAsync(Product product);
    Task<bool> UpdateAsync(Product product);
    Task<bool> DeleteAsync(Product product);

    Task<Product> FindByPredicateAsync(
        Expression<Func<Product, bool>> predicate,
        Func<IQueryable<Product>, IIncludableQueryable<Product, object>>? include = null,
        bool asNoTracking = false);

    Task<List<Product>> FindAllByPredicateAsync(
        Expression<Func<Product, bool>> predicate,
        Func<IQueryable<Product>, IIncludableQueryable<Product, object>>? include = null,
        bool toQuery = false);
    
}