using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.EntityFrameworkCore;
using OrderManagerBack.Database;
using OrderManagerBack.Entities;

namespace OrderManagerBack.Controllers
{
    [ApiController]
    [Route("api/orders")]
    public class OrderController : ControllerBase
    {
        private readonly OrderManagerContext _ctx;

        public OrderController(OrderManagerContext ctx)
        {
            _ctx = ctx;
        }

        [HttpGet("GetOrders", Name = "GetOrders")]
        public ActionResult GetOrders() {
            // TODO
            return Ok(new
            {
                orders = _ctx.Orders.Include(order => order.Product)
                    .Include(order => order.Product.Materials).Select(o => o.ToDto()).ToList()
            });
        }

        [HttpGet("GetProduction", Name = "GetProduction")]
        public ActionResult GetProduction()
        {
            // TODO
            return null;
        }

        [HttpPost("SetProduction", Name = "SetProduction")]
        public ActionResult SetProduction([FromQuery(Name = "email")] string? email)
        {
            // TODO
            return null;
        }
    }
}
