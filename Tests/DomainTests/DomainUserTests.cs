using Application.Exceptions;
using Domain.Entities;

namespace Tests.DomainTests
{
    public class DomainUserTests
    {
        [Fact]
        public void When_User_ConstructedWithValidData_Then_PropertiesAreSetCorrectly()
        {
            // Arrange
            int userId = 1;
            string name = "admin";
            DateTime createUserAt = DateTime.Now;

            // Act
            User user = new User
            {
                Id = userId,
                Name = name,
                CreatedAt = createUserAt,
            };

            // Assert
            Assert.Equal(userId, user.Id);
            Assert.Equal(name, user.Name);
            Assert.Equal(createUserAt, user.CreatedAt);
        }
    }
}