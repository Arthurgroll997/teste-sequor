using System.Reflection.Metadata;
using Microsoft.EntityFrameworkCore;
using OrderManagerBack.Database;

namespace OrderManagerTests
{
    public class TestDatabaseFixture
    {
        private const string ConnectionString = @"Server=localhost;Database=testing_sequor;User Id=sa;Password=#$3quoR123;Encrypt=True;TrustServerCertificate=True;Integrated Security=false;";

        private static readonly object _lock = new();
        private static bool _databaseInitialized;

        public TestDatabaseFixture()
        {
            lock (_lock)
            {
                if (!_databaseInitialized)
                {
                    using (var context = CreateContext())
                    {
                        context.Database.EnsureDeleted();
                        context.Database.EnsureCreated();
                        
                        context.Seed();
                    }

                    _databaseInitialized = true;
                }
            }
        }

        public OrderManagerContext CreateContext()
            => new OrderManagerContext(
                new DbContextOptionsBuilder<OrderManagerContext>()
                    .UseSqlServer(ConnectionString)
                    .Options);
    }
}
