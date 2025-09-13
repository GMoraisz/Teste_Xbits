using Teste_Xbits.ApplicationService.DataTransferObjects.CategoryDtos.Request;
using Teste_Xbits.ApplicationService.DataTransferObjects.CategoryDtos.Response;
using Teste_Xbits.Domain.Entities;

namespace Teste_Xbits.ApplicationService.Interfaces.MapperContracts;

public interface ICategoryMapper
{
    Category DtoRegisterToDomain(CategorySaveRequest dtoRegister);
    Category DtoUpdateToDomain(Category product, CategoryUpdateRequest dtoUpdate);
    CategoryResponse DomainToDtoResponse(Category domain);
}