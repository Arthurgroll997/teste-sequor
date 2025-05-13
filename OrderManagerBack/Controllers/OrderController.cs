using Microsoft.AspNetCore.Mvc;
using OrderManagerBack.Database;
using OrderManagerBack.Entities;

namespace OrderManagerBack.Controllers
{
    [ApiController]
    [Route("api/orders/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly OrderManagerContext _ctx;

        public OrderController(OrderManagerContext ctx)
        {
            _ctx = ctx;
        }

        [HttpGet(Name = "GetOrders")]
        public string? GetOrders() {
            // TODO
            return null;
        }

        [HttpGet(Name = "GetProduction")]
        public string? GetProduction([FromQuery(Name = "email")] string? email)
        {
            // TODO
            return null;
        }

        [HttpPost(Name = "SetProduction")]
        public string? SetProduction()
        {
            // TODO
            return null;
        }
    }
}
