using Teste_Xbits.ApplicationService.DataTransferObjects.CategoryDtos.Request;
using Teste_Xbits.ApplicationService.DataTransferObjects.CategoryDtos.Response;
using Teste_Xbits.ApplicationService.Interfaces.MapperContracts;
using Teste_Xbits.Domain.Entities;
using Teste_Xbits.Domain.Enums;
using Teste_Xbits.Domain.Handlers.PaginationHandler;

namespace Teste_Xbits.ApplicationService.Mappers;

public sealed class CategoryMapper : ICategoryMapper
{
    public Category DtoRegisterToDomain(CategorySaveRequest dtoRegister) =>
        new()
        {
            Id = dtoRegister.Id,
            Name = dtoRegister.Name,
        };

    public Category DtoUpdateToDomain(Category category, CategoryUpdateRequest dtoUpdate)
    {
        category.Name = dtoUpdate.Name;
        return category;
    }

    public CategoryResponse DomainToDtoResponse(Category domain) =>
        new()
        {
            Id = domain.Id,
            Name = domain.Name
        };
    
    public Category DtoCategoryResponse(Category domain)
    {
        return new Category
        {
            Id = domain.Id,
            Name = domain.Name,
            
        };
    }
}