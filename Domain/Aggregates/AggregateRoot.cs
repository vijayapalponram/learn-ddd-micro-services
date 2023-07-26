using Domain.Primitives;

namespace Domain.Aggregates
{
    public abstract class AggregateRoot: Entity
    {
        private readonly List<IDomainEvent> domainEvents = new();
        protected AggregateRoot(Guid id): base(id) {

        }

        protected void RaiseDomainEvent(IDomainEvent domainEvent){
            domainEvents.Add(domainEvent);
        }
    }
}