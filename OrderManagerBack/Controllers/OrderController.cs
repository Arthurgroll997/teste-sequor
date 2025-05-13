using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrderManagerBack.Database;
using OrderManagerBack.Dto;
using OrderManagerBack.Entities;
using OrderManagerBack.Models;

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

        private BadRequestObjectResult BadReq(string message) => BadRequest(new SetProductionStatusDto()
            {
                Status = Constants.DEFAULT_ERROR_STATUS,
                Type = Constants.DEFAULT_ERROR_CHARACTER,
                Description = message,
            });

        [HttpPost("SetProduction", Name = "SetProduction")]
        public ActionResult SetProduction([FromBody] SetProductionInputDto productionInfo)
        {
            var user = new User() { Email = productionInfo.Email };
            var order = new Order() { OrderCode = productionInfo.Order };

            if (!user.IsRegistered(_ctx))
                return BadReq(Constants.SET_PRODUCTION_INVALID_EMAIL);

            if (!order.Exists(_ctx))
                return BadReq(Constants.SET_PRODUCTION_INVALID_ORDER);

            _ctx.Add(new Production()
            {
                Email = productionInfo.Email,
                OrderObj = _ctx.Orders.Where(o => o.OrderCode == productionInfo.Order).First()!,
                Date = DateTime.Parse($"{productionInfo.ProductionDate} {productionInfo.ProductionTime}"),
                Quantity = productionInfo.Quantity,
                Material = _ctx.Materials.Where(m => m.MaterialCode == productionInfo.MaterialCode).First()!,
                CycleTime = productionInfo.CycleTime,
            });

            _ctx.SaveChanges();

            var successResult = new SetProductionStatusDto()
            {
                Status = Constants.DEFAULT_SUCCESS_STATUS,
                Type = Constants.DEFAULT_SUCCESS_CHARACTER,
                Description = Constants.APPOINTMENT_SUCCESS,
            };

            return CreatedAtRoute(
                routeName: nameof(SetProduction),
                routeValues: successResult,
                value: successResult);
        }
    }
}
