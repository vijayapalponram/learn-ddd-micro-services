using Domain.Primitives;

namespace Domain.DomainEvents
{
    public sealed record OrderSubmittedDomainEvent(Guid OrderId, Guid CustomerId): IDomainEvent
    {
        
    }
}