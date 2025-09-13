using Teste_Xbits.ApplicationService.DataTransferObjects.ProductDtos.Request;
using Teste_Xbits.ApplicationService.DataTransferObjects.ProductDtos.Response;
using Teste_Xbits.Domain.Entities;

namespace Teste_Xbits.ApplicationService.Interfaces.MapperContracts;

public interface IProductMapper
{
    Product DtoRegisterToDomain(ProductSaveRequest dtoRegister);
    Product DtoUpdateToDomain(Product product, ProductUpdateRequest dtoUpdate);
    ProductResponse DomainToDtoResponse(Product domain);
    // List<ProductResponse> DomainToDtoResponseList(IEnumarable<Product> domainList);

}