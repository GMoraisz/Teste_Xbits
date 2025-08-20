namespace Teste_Xbits.Domain.Entities;

public class Product
{
    public long Id { get; set; }
    public string? Name { get; set; }
    public decimal Price { get; set; }
    
    public long CategoryId { get; set; }
    public Category? Category { get; set; }
}