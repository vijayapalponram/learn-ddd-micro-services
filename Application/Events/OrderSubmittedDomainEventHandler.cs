using Domain.DomainEvents;
using MediatR;

namespace Application.Events
{
    public class OrderSubmittedDomainEventHandler : INotificationHandler<OrderSubmittedDomainEvent>
    {
        public Task Handle(OrderSubmittedDomainEvent notification, CancellationToken cancellationToken)
        {
            Console.WriteLine("Order has been submitted successfully.  Order Id is {0}", notification.OrderId);
            throw new NotImplementedException();
        }
    }
}