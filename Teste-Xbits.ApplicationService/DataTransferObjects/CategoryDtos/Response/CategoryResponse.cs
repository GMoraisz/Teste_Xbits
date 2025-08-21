namespace Teste_Xbits.ApplicationService.DataTransferObjects.CategoryDtos.Response;

public sealed record CategoryResponse
{
    public long Id { get; set; }
    public string? Name { get; set; }
}