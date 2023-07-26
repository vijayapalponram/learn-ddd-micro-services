using System;
using System.Threading;
using System.Threading.Tasks;
using Application.Ports;
using Domain.Aggregates;
using Domain.Entities;
using Domain.ValueObjects;
using MediatR;
using Microsoft.AspNetCore.Http;
using WebApi.Message.Commands;

namespace WebApi.Message.Handlers
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, Boolean>
    {
        private IOrderService _orderService;
        public CreateOrderCommandHandler(IOrderService orderService){
            _orderService = orderService;
        }

        public async Task<Boolean> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            var order = Order.CreateOrder(new CustomerId(request.OrderDto.CustomerId));

            request.OrderDto.Products.ForEach(
                p => order.AddLineItem(
                    new ProductId(p.ProductId),
                    new Money(p.Currency, p.Price)
                )
            );
            
            await _orderService.AddAsync(order);

            return true;
        }
    }
}