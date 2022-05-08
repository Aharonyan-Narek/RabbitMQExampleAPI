using Microsoft.AspNetCore.Mvc;
using RabbitMQExampleAPI.DTOs;
using RabbitMQExampleAPI.Producers;

namespace RabbitMQExampleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IMessageProducer _messagePublisher;
        public OrdersController(IMessageProducer messagePublisher)
        {
            _messagePublisher = messagePublisher;
        }

        [HttpPost]
        public IActionResult CreateOrder(OrderDto orderDto)
        {
            _messagePublisher.SendMessage(orderDto);

            return Ok();
        }
    }
}
