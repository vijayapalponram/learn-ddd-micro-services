using System.Threading;
using System.Threading.Tasks;
using Application.Ports;
using Domain.Aggregates;
using MediatR;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.DTOs;
using WebApi.Message.Commands;

namespace WebApi.Endpoints
{
    [ApiController]
    [Route("orders")]
    public class CreateOrderEndpoint : ControllerBase
    {
        private ISender _sender;
        public CreateOrderEndpoint(ISender sender){
            _sender = sender;
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder(CreateOrderDto order, CancellationToken cancellationToken){

            var result = await _sender.Send(new CreateOrderCommand(order), cancellationToken);

            return result ? Ok(result) : BadRequest(result);
        }
    }
}
