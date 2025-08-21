using Teste_Xbits.Domain.Entities.Base;

namespace Teste_Xbits.Domain.Entities;
public class Category : BaseEntity
{
    public long Id { get; set; }
    public string? Name { get; set; }
    
    public ICollection<Product> Products { get; set; } = new List<Product>();
}