using Microsoft.EntityFrameworkCore;
using OrderManagerBack.Entities;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OrderManagerBack.Database.Seeders
{
    public class UserSeeder
    {
        private readonly DbContext _context;

        public UserSeeder(DbContext context)
        {
            _context = context;
        }

        public void Populate()
        {
            var userTest = _context.Set<User>().FirstOrDefault();

            if (userTest == null)
            {
                _context.Set<User>().Add(new User()
                {
                    Email = "teste@sequor.com.br",
                    Name = "Teste Sequor",
                    InitialDate = DateTime.Now,
                    EndDate = DateTime.Now.AddDays(7),
                });
            }

            _context.SaveChanges();
        }
    }
}
