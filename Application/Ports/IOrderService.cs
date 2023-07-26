using Domain.Aggregates;

namespace Application.Ports
{
    public interface IOrderService
    {
        public Task<Order> AddAsync(Order order);
    }
}