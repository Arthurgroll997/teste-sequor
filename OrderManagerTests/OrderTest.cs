using Microsoft.AspNetCore.Mvc;
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

            var producoes = orderController.GetProduction();

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
        public void SetProductionShouldWorkCorrecty()
        {

        }

        [Fact]
        public void SetProductionShouldNotWorkWithInvalidEmail()
        {

        }

        [Fact]
        public void SetProductionShouldNotWithoutEmail()
        {

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
