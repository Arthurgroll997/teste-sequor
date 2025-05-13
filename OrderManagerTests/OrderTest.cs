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
        public async Task GetOrdersShouldReturnSuccessfully()
        {
            using var context = Fixture.CreateContext();
            var orderController = new OrderController(context);

            var ordens = orderController.GetOrders();

            var okResult = Assert.IsType<OkObjectResult>(ordens);

            dynamic returnValue = okResult.Value;
            Assert.NotNull(returnValue);

            var ordersProperty = returnValue.GetType().GetProperty("orders");
            Assert.NotNull(ordersProperty);

            var orders = ordersProperty.GetValue(returnValue) as IEnumerable<OrderDto>;
            Assert.NotNull(orders);
            Assert.NotEmpty(orders);
        }

        [Fact]
        public async Task GetProductionShouldReturnSuccessfully()
        {

        }

        [Fact]
        public async Task SetProductionShouldWorkCorrecty()
        {

        }

        [Fact]
        public async Task SetProductionShouldNotWorkWithInvalidEmail()
        {

        }

        [Fact]
        public async Task SetProductionShouldNotWithoutEmail()
        {

        }

        [Fact]
        public async Task SetProductionShouldNotWorkWhenInvalidOrderIsGiven()
        {

        }

        [Fact]
        public async Task SetProductionShouldNotWorkWhenUserAppointedDateExpired()
        {

        }

        [Fact]
        public async Task SetProductionShouldNotWorkWhenUserTriesBeforeAppointedDate()
        {

        }

        [Fact]
        public async Task SetProductionShouldNotWorkWithQuantityLessThanOrEqualToZero()
        {

        }

        [Fact]
        public async Task SetProductionShouldNotWorkWithQuantityGreaterThanOrderQuantity()
        {

        }

        [Fact]
        public async Task SetProductionShouldNotWorkWithMaterialsNotIncludedInOrder()
        {

        }

        [Fact]
        public async Task SetProductionShouldNotWorkWithCycleTimeLessThanZero()
        {

        }

        [Fact]
        public async Task SetProductionShouldWorkButWarnWhenCycleTimeLessThanProductCycleTime()
        {

        }
    }
}
