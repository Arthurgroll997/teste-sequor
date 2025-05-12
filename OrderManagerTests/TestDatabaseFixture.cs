using System.Reflection.Metadata;

namespace OrderManagerTests
{
    public class TestDatabaseFixture
    {
        private const string ConnectionString = @"Server=localhost;Database=sequor;User Id=sa;Password=myPassword;";

        private static readonly object _lock = new();
        private static bool _databaseInitialized;

        public TestDatabaseFixture()
        {
            lock (_lock)
            {
                if (!_databaseInitialized)
                {
                    //using (var context = CreateContext())
                    //{
                    //    context.Database.EnsureDeleted();
                    //    context.Database.EnsureCreated();
                    //    context.AddRange(
                    //        new Blog { Name = "Blog1", Url = "http://blog1.com" },
                    //        new Blog { Name = "Blog2", Url = "http://blog2.com" });
                    //    context.SaveChanges();
                    //}

                    _databaseInitialized = true;
                }
            }
        }

        //public BloggingContext CreateContext()
        //    => new BloggingContext(
        //        new DbContextOptionsBuilder<BloggingContext>()
        //            .UseSqlServer(ConnectionString)
        //            .Options);
    }
}
