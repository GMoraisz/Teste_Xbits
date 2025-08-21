namespace Teste_Xbits.ApplicationService.DataTransferObjects.CategoryDtos.Request;

public sealed record CategoryUpdateRequest
{
    public long Id { get; init; }
    public string? Name { get; init; }
}