using Microsoft.AspNetCore.Mvc;
using OrderManagerBack;
using OrderManagerBack.Controllers;
using OrderManagerBack.Dto;

namespace OrderManagerTests
{
    public class OrderTest : IClassFixture<TestDatabaseFixture>
    {
        public TestDatabaseFixture Fixture { get; set; }

        public OrderTest(TestDatabaseFixture fixture)
        {
            Fixture = fixture;
        }

        [Fact]
        public void GetOrdersShouldReturnSuccessfully()
        {
            using var context = Fixture.CreateContext();
            var orderController = new OrderController(context);

            var ordens = orderController.GetOrders();

            var okResult = Assert.IsType<OkObjectResult>(ordens);

            dynamic returnValue = okResult.Value;
            Assert.NotNull(returnValue);

            var ordersProperty = returnValue!.GetType().GetProperty("orders");
            Assert.NotNull(ordersProperty);

            var orders = ordersProperty.GetValue(returnValue) as IEnumerable<OrderDto>;
            Assert.NotNull(orders);
            Assert.NotEmpty(orders);

            Assert.Equal(2, orders.Count());

            var product = context.Orders.Where(o => o.Product.ProductCode == "001").First().ToDto();
            Assert.Equal(orders.First().ProductCode, product.ProductCode);
        }

        [Fact]
        public void GetProductionShouldReturnSuccessfully()
        {
            using var context = Fixture.CreateContext();
            var orderController = new OrderController(context);

            var producoes = orderController.GetProduction("teste@sequor.com.br");

            var okResult = Assert.IsType<OkObjectResult>(producoes);

            dynamic returnValue = okResult.Value;
            Assert.NotNull(returnValue);

            var productionsProperty = returnValue!.GetType().GetProperty("productions");
            Assert.NotNull(productionsProperty);

            var productions = productionsProperty.GetValue(returnValue) as IEnumerable<ProductionDto>;
            Assert.NotNull(productions);
            Assert.NotEmpty(productions);

            Assert.Equal(2, productions.Count());

            var material = context.Productions.Where(o => o.Material.MaterialCode == "001").First().ToDto();
            Assert.Equal(productions.First().MaterialCode, material.MaterialCode);
        }

        [Fact]
        public void GetProductionShouldReturnEmptyListWhenEmailMatchesNoProductions()
        {
            using var context = Fixture.CreateContext();
            var orderController = new OrderController(context);

            var producoes = orderController.GetProduction("inexistente@sequor.com.br");

            var okResult = Assert.IsType<OkObjectResult>(producoes);

            dynamic returnValue = okResult.Value;
            Assert.NotNull(returnValue);

            var productionsProperty = returnValue!.GetType().GetProperty("productions");
            Assert.NotNull(productionsProperty);

            var productions = productionsProperty.GetValue(returnValue) as IEnumerable<ProductionDto>;
            Assert.NotNull(productions);
            Assert.Empty(productions);
        }
        
        [Fact]
        public void SetProductionShouldWorkCorrecty()
        {
            using var context = Fixture.CreateContext();
            var orderController = new OrderController(context);

            var newProductionDto = new SetProductionInputDto()
            {
                Email = "teste@sequor.com.br",
                Order = "001",
                ProductionDate = DateTime.Now.AddMinutes(10).ToString("yyyy-MM-dd"),
                ProductionTime = TimeSpan.FromMinutes(10.5).ToString(@"hh\:mm\:ss"),
                Quantity = 30,
                MaterialCode = "001",
                CycleTime = 15m,
            };

            var result = orderController.SetProduction(newProductionDto);

            var createdAtResult = Assert.IsType<CreatedAtRouteResult>(result);

            dynamic returnValue = createdAtResult.Value;
            Assert.NotNull(returnValue);

            var productionResult = (returnValue as SetProductionStatusDto)!;

            Assert.Equal(Constants.DEFAULT_SUCCESS_STATUS, productionResult.Status);
            Assert.Equal(Constants.DEFAULT_SUCCESS_CHARACTER, productionResult.Type);
            Assert.Equal(Constants.APPOINTMENT_SUCCESS, productionResult.Description);
            Assert.Equal(3, context.Productions.Count());
        }

        [Fact]
        public void SetProductionShouldNotWorkWithInvalidEmail()
        {
            using var context = Fixture.CreateContext();
            var orderController = new OrderController(context);

            var newProductionDto = new SetProductionInputDto()
            {
                Email = "invalido@sequor.com.br",
                Order = "001",
                ProductionDate = DateTime.Now.AddMinutes(10).ToString("yyyy-MM-dd"),
                ProductionTime = TimeSpan.FromMinutes(10.5).ToString(@"hh\:mm\:ss"),
                Quantity = 30,
                MaterialCode = "001",
                CycleTime = 15m,
            };

            var result = orderController.SetProduction(newProductionDto);

            var badReqResult = Assert.IsType<BadRequestObjectResult>(result);

            dynamic returnValue = badReqResult.Value;
            Assert.NotNull(returnValue);

            var productionResult = (returnValue as SetProductionStatusDto)!;

            Assert.Equal(Constants.DEFAULT_ERROR_STATUS, productionResult.Status);
            Assert.Equal(Constants.DEFAULT_ERROR_CHARACTER, productionResult.Type);
            Assert.Equal(Constants.SET_PRODUCTION_INVALID_EMAIL, productionResult.Description);
        }

        [Fact]
        public void SetProductionShouldNotWorkWithoutEmail()
        {
            using var context = Fixture.CreateContext();
            var orderController = new OrderController(context);

            var newProductionDto = new SetProductionInputDto()
            {
                Email = "",
                Order = "001",
                ProductionDate = DateTime.Now.AddMinutes(10).ToString("yyyy-MM-dd"),
                ProductionTime = TimeSpan.FromMinutes(10.5).ToString(@"hh\:mm\:ss"),
                Quantity = 30,
                MaterialCode = "001",
                CycleTime = 15m,
            };

            var result = orderController.SetProduction(newProductionDto);

            var badReqResult = Assert.IsType<BadRequestObjectResult>(result);

            dynamic returnValue = badReqResult.Value;
            Assert.NotNull(returnValue);

            var productionResult = (returnValue as SetProductionStatusDto)!;

            Assert.Equal(Constants.DEFAULT_ERROR_STATUS, productionResult.Status);
            Assert.Equal(Constants.DEFAULT_ERROR_CHARACTER, productionResult.Type);
            Assert.Equal(Constants.SET_PRODUCTION_INVALID_EMAIL, productionResult.Description);
        }

        [Fact]
        public void SetProductionShouldNotWorkWhenInvalidOrderIsGiven()
        {

        }

        [Fact]
        public void SetProductionShouldNotWorkWhenUserAppointedDateExpired()
        {

        }

        [Fact]
        public void SetProductionShouldNotWorkWhenUserTriesBeforeAppointedDate()
        {

        }

        [Fact]
        public void SetProductionShouldNotWorkWithQuantityLessThanOrEqualToZero()
        {

        }

        [Fact]
        public void SetProductionShouldNotWorkWithQuantityGreaterThanOrderQuantity()
        {

        }

        [Fact]
        public void SetProductionShouldNotWorkWithMaterialsNotIncludedInOrder()
        {

        }

        [Fact]
        public void SetProductionShouldNotWorkWithCycleTimeLessThanZero()
        {

        }

        [Fact]
        public void SetProductionShouldWorkButWarnWhenCycleTimeLessThanProductCycleTime()
        {

        }
    }
}
