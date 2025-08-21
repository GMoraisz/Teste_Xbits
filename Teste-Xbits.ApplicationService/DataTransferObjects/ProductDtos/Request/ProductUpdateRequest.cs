namespace Teste_Xbits.ApplicationService.DataTransferObjects.ProductDtos.Request;

public sealed record ProductUpdateRequest
{
    public long Id { get; init; }
    public string? Name { get; init; }
    public decimal Price { get; init; }
    public long CategoryId { get; init; }
}