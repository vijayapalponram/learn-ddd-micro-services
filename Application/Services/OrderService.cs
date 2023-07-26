using Application.Ports;
using Domain.Aggregates;
using Domain.Ports;

namespace Application.Services
{
    public class OrderService: IOrderService
    {
        private IOrderRepository orderRepository;

        public OrderService(IOrderRepository orderRepository){
            this.orderRepository = orderRepository;
        }

        public Task<Order> AddAsync(Order order)
        {
            return orderRepository.AddAsync(order);
        }
    }
}