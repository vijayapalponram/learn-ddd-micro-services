using System.Globalization;
using Domain.ValueObjects;

namespace Domain.Entities
{

    public class OrderLineItem {
        public OrderLineItemId Id { get; private set;}
        public Guid OrderId { get; private set;}
        public ProductId ProductId { get; private set; }
        public Money Price { get; private set; }
        public int Discount { get; private set;}

        public OrderLineItem(){
            
        }
        public OrderLineItem(OrderLineItemId id, Guid orderId, ProductId productId, Money price){
            Id  = id;
            ProductId = productId;
            Price = price;
            OrderId = orderId;
        }
    }
}