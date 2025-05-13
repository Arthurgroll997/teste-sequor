using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.EntityFrameworkCore;
using OrderManagerBack.Database;
using OrderManagerBack.Dto;
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
        public ActionResult GetOrders()
        {
            return Ok(new
            {
                orders = _ctx.Orders.Include(order => order.Product)
                    .Include(order => order.Product.Materials).Select(o => o.ToDto()).ToList(),
            });
        }

        [HttpGet("GetProduction", Name = "GetProduction")]
        public ActionResult GetProduction([FromQuery(Name = "email")] string? email)
        {
            return Ok(new
            {
                productions = _ctx.Productions.Include(prod => prod.OrderObj)
                    .Include(prod => prod.Material).Where(prod => prod.Email == email).Select(o => o.ToDto()).ToList(),
            });
        }

        [HttpPost("SetProduction", Name = "SetProduction")]
        public ActionResult SetProduction([FromBody] SetProductionInputDto productionInfo)
        {
            var user = new User() { Email = productionInfo.Email };

            if (!user.IsRegistered(_ctx))
            {
                return BadRequest(new SetProductionStatusDto()
                {
                    Status = Constants.DEFAULT_ERROR_STATUS,
                    Type = Constants.DEFAULT_ERROR_CHARACTER,
                    Description = Constants.SET_PRODUCTION_INVALID_EMAIL,
                });
            }

            var finalResult = new SetProductionStatusDto()
            {
                Status = Constants.DEFAULT_SUCCESS_STATUS,
                Type = Constants.DEFAULT_SUCCESS_CHARACTER,
                Description = Constants.APPOINTMENT_SUCCESS,
            };

            return CreatedAtRoute(
                routeName: nameof(SetProduction),
                routeValues: finalResult,
                value: finalResult);
        }
    }
}
