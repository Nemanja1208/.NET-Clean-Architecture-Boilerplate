using Domain.Entities;
using Infrastructure.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DummyApplicationDatabase _database;

        public UserRepository(DummyApplicationDatabase database)
        {
            _database = database;
        }

        public async Task<User> GetUserById(int userId)
        {
            List<User> allUsers = _database.Users;

            User userWeAreLookingFor = allUsers.FirstOrDefault(user => user.Id == userId)!;

            return await Task.FromResult(userWeAreLookingFor);
        }
    }
}
