using Domain.ValueObjects;
using Domain.Entities;
using Domain.DomainEvents;

namespace Domain.Aggregates
{
    public class Order: AggregateRoot
    {
        
        public CustomerId CustomerId { get; private set; }

        private readonly List<OrderLineItem> orderLineItems = new();

        public IReadOnlyList<OrderLineItem> OrderLineItems => orderLineItems.ToList();
    
        private Order(Guid id, CustomerId customerId): base(id){
            CustomerId = customerId;
        }

        public static Order CreateOrder(CustomerId customerId){
            return new Order(new Guid(), customerId);
        }

        public void AddLineItem(ProductId productId, Money price){
            var orderLineItem = new OrderLineItem(new OrderLineItemId(new Guid()), Id, productId, price);
            this.orderLineItems.Add(orderLineItem);
        }

        public void SubmitOrder(Order order){
            //RaiseDomainEvent(new OrderSubmittedDomainEvent(order.Id, order.CustomerId.Value));
        }
    }
}
