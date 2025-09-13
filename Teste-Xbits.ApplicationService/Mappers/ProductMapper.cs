using Teste_Xbits.ApplicationService.DataTransferObjects.ProductDtos.Request;
using Teste_Xbits.ApplicationService.DataTransferObjects.ProductDtos.Response;
using Teste_Xbits.ApplicationService.Interfaces.MapperContracts;
using Teste_Xbits.Domain.Entities;
using Teste_Xbits.Domain.Enums;
using Teste_Xbits.Domain.Handlers.PaginationHandler;

namespace Teste_Xbits.ApplicationService.Mappers;

public sealed class ProductMapper : IProductMapper
{
    public Product DtoRegisterToDomain(ProductSaveRequest dtoRegister) =>
       new()
        {
            Id = dtoRegister.Id,
            Name = dtoRegister.Name,
            Price = dtoRegister.Price,
            CategoryId = dtoRegister.CategoryId
        };
    

    public Product DtoUpdateToDomain(Product product, ProductUpdateRequest dtoUpdate)
    {
        product.Id = dtoUpdate.Id;
        product.Name = dtoUpdate.Name;
        product.Price = dtoUpdate.Price;
        product.CategoryId = dtoUpdate.CategoryId;

        return product;
    }

    public ProductResponse DomainToDtoResponse(Product domain) =>
    
        new()
        {
            Id = domain.Id,
            Name = domain.Name,
            Price = domain.Price,
            CategoryId = domain.CategoryId
        };
    
}