namespace Teste_Xbits.ApplicationService.DataTransferObjects.ProductDtos.Request;

public sealed record ProductSaveRequest
{
    public long Id { get; set; }
    public string? Name { get; set;}
    public decimal Price { get; set; }
    public long CategoryId { get; set; }
}