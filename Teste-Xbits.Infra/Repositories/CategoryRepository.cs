using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Teste_Xbits.Domain.Entities;
using Teste_Xbits.Infra.Interfaces.RepositoryContracts;
using Teste_Xbits.Infra.Interfaces.ServiceContracts;
using Teste_Xbits.Infra.ORM.Context;
using Teste_Xbits.Infra.Repositories.Base;

namespace Teste_Xbits.Infra.Repositories;

public sealed class CategoryRepository(
    ApplicationContext dbContext)
    : RepositoryBase<Category>(dbContext), ICategoryRepository
{
    public async Task<bool> SaveAsync(Category category)
    {
        await DbSetContext.AddAsync(category);
        return await SaveInDatabaseAsync();
    }

    public async Task<bool> UpdateAsync(Category category)
    {
      
        DbSetContext.Update(category); 
        return await SaveInDatabaseAsync();
    }

    public async Task<bool> DeleteAsync(Category category)
    {
        DbSetContext.Remove(category);
        return await SaveInDatabaseAsync();
    }
}