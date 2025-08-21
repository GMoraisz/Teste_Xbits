using Teste_Xbits.Domain.Entities.Base;

namespace Teste_Xbits.Domain.Entities;
public sealed class DomainLogger : BaseEntity
{
    public long Id { get; init; }
    public DateTime ActionDate { get; init; }
    public required string Description { get; init; }
    public Guid UserId { get; init; }
    public string? EntityId { get; init; }
}