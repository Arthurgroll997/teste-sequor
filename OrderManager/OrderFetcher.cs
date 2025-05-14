using System.Reflection.Metadata;
using System.Text.Json;
using System.Text.Json.Nodes;
using OrderManagerBack.Dto;

namespace OrderManagerFront
{
    public static class OrderFetcher
    {
        private const string baseUrl = "http://localhost:5066/api/orders";
        private const string setProductionRoute = $"{baseUrl}/SetProduction";
        private const string getProductionRoute = $"{baseUrl}/GetProduction";
        private const string getOrdersRoute = $"{baseUrl}/GetOrders";

        private static JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
        };

        static readonly HttpClient client = new HttpClient();

        public static List<ProductionDto> GetProductionForEmail(string email)
        {
            HttpResponseMessage response = client.GetAsync(getProductionRoute + $"?email={email}").Result;

            response.EnsureSuccessStatusCode();

            string responseBody = response.Content.ReadAsStringAsync().Result;

            var jsonDoc = JsonDocument.Parse(responseBody);
            var root = jsonDoc.RootElement;
            var productionsElement = root.GetProperty("productions");

            var txt = productionsElement.GetRawText();

            List<ProductionDto> productions =
                JsonSerializer.Deserialize<List<ProductionDto>>(productionsElement.GetRawText(), jsonSerializerOptions)!;

            return productions;
        }

        public static List<OrderDto> GetOrders()
        {
            HttpResponseMessage response = client.GetAsync(getOrdersRoute).Result;

            response.EnsureSuccessStatusCode();

            string responseBody = response.Content.ReadAsStringAsync().Result;

            var jsonDoc = JsonDocument.Parse(responseBody);
            var root = jsonDoc.RootElement;
            var productionsElement = root.GetProperty("orders");

            var txt = productionsElement.GetRawText();

            List<OrderDto> orders =
                JsonSerializer.Deserialize<List<OrderDto>>(productionsElement.GetRawText(), jsonSerializerOptions)!;

            return orders;
        }
    }
}
