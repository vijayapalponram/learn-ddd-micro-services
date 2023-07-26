using System;
using MediatR;
using WebApi.DTOs;

namespace WebApi.Message.Commands
{
    public record CreateOrderCommand(CreateOrderDto OrderDto) : IRequest<Boolean>;
    
}