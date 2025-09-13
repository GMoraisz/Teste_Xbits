using Teste_Xbits.Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Teste_Xbits.Infra.Interfaces.RepositoryContracts;

public interface ICategoryRepository
{
    Task<bool> SaveAsync(Category category);
    Task<bool> UpdateAsync(Category category);
    Task<bool> DeleteAsync(Category category);

    Task<Category> FindByPredicateAsync(
        Expression<Func<Category, bool>> predicate,
        Func<IQueryable<Category>, IIncludableQueryable<Category, object>>? include = null,
        bool asNoTracking = false);

    Task<List<Category>> FindAllByPredicateAsync(
        Expression<Func<Category, bool>> predicate,
        Func<IQueryable<Category>, IIncludableQueryable<Category, object>>? include = null,
        bool toQuery = false);
    
}