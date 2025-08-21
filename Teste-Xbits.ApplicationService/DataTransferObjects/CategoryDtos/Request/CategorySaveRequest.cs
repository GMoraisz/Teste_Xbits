namespace Teste_Xbits.ApplicationService.DataTransferObjects.CategoryDtos.Request;

public sealed record CategorySaveRequest
{
    public long Id { get; set; }
    public string? Name { get; set; }
}