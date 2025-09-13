using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Teste_Xbits.Domain.Entities;
using Teste_Xbits.Infra.Interfaces.RepositoryContracts;
using Teste_Xbits.Infra.Interfaces.ServiceContracts;
using Teste_Xbits.Infra.ORM.Context;
using Teste_Xbits.Infra.Repositories.Base;

namespace Teste_Xbits.Infra.Repositories;

public sealed class ProductRepository(
    ApplicationContext dbContext)
    : RepositoryBase<Product>(dbContext), IProductRepository
{
    public async Task<Product> SaveAsync(Product product)
    {
        await DbSetContext.AddAsync(product);
        await SaveInDatabaseAsync();

        return product;
    }

    public Task<bool> UpdateAsync(Product product)
    {
        DetachedObject(product);
        DbSetContext.Update(product);
        return SaveInDatabaseAsync();
    }

    public Task<bool> DeleteAsync(Product product)
    {
        DbSetContext.Remove(product);
        return SaveInDatabaseAsync();
    }
}