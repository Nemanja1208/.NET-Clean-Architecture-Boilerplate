using Application.Exceptions;
using Application.Interfaces;
using Application.Services;
using Domain.Entities;
using Infrastructure.Database;
using Infrastructure.Repositories;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests.ApplicationTests.ServiceTests.UserServiceTests.UserServiceSetupFixture;
using Xunit.Abstractions;

namespace Tests.ApplicationTests.ServiceTests.UserServiceTests
{
    public class UserServiceTests : IClassFixture<UserServiceFixture>
    {
        private readonly UserService _userService;
        private readonly UserServiceFixture _userServiceFixture;

        public UserServiceTests(UserServiceFixture fixture)
        {
            _userServiceFixture = fixture;
            _userService = fixture.UserService;
        }

        [Fact]
        public async Task When_GetUserById_WithInvalidUserId_Then_ThrowsNotFoundException()
        {
            // Arrange
            int userId = 8;

            // Act and Assert
            await Assert.ThrowsAsync<NotFoundException>(() => _userService.GetUserById(userId));
        }

        [Fact]
        public async Task When_GetUserById_WithValidUserId_Then_ReturnsUserDto()
        {
            // Arrange
            int userId = 1;

            // Act
            _userServiceFixture.UserRepositoryMock.Setup(repo => repo.GetUserById(userId)).ReturnsAsync(new User { Id = userId, Name = "Admin" });

            var result = await _userService.GetUserById(userId);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(userId, result.Id);
        }
    }
}
