using System;
using Application.Services;
using Domain.Entities;
using Infrastructure.Repositories;
using Moq;

namespace Tests.ApplicationTests.ServiceTests.UserServiceTests.UserServiceSetupFixture
{
    public class UserServiceFixture : IDisposable
    {
        public IUserRepository UserRepository { get; private set; }
        public UserService UserService { get; private set; }
        public Mock<IUserRepository> UserRepositoryMock { get; private set; }

        public UserServiceFixture()
        {
            // Create a Mock for IUserRepository with Moq package
            UserRepositoryMock = new Mock<IUserRepository>();

            // Use the Mock.Object as the IUserRepository instance in your UserService
            UserRepository = UserRepositoryMock.Object;

            // Create the UserService using the mocked repository
            UserService = new UserService(UserRepository);
        }

        public void Dispose()
        {
            // Clean up resources if needed
        }
    }
}
