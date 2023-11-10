using Domain.Entities;
using Infrastructure.Database;
using Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.InfrastructureTests.UserRepositoryTests
{
    public class UserRepositoryTests
    {
        [Fact]
        public async Task When_GetUserById_WithValidUserId_Then_ReturnsUser()
        {
            // Arrange
            int userId = 1;
            var database = new DummyApplicationDatabase();
            var userRepository = new UserRepository(database);

            var userToReturn = new User { Id = userId, Name = "John Doe" };
            database.Users = new List<User> { userToReturn };

            // Act
            var result = await userRepository.GetUserById(userId);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(userId, result.Id);
            Assert.Equal(userToReturn.Name, result.Name);
        }

        [Fact]
        public async Task When_GetUserById_WithInvalidUserId_Then_ReturnsNull()
        {
            // Arrange
            int userId = 1;
            var database = new DummyApplicationDatabase();
            var userRepository = new UserRepository(database);

            // Empty list, simulating no users in the database
            database.Users = new List<User>();

            // Act
            var result = await userRepository.GetUserById(userId);

            // Assert
            Assert.Null(result);
        }
    }
}
