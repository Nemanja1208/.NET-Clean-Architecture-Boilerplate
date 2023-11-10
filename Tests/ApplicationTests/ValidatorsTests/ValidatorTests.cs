using Application.Dtos;
using Application.Exceptions;
using Application.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.ApplicationTests.ValidatorsTests
{
    public class ValidatorTests
    {
        [Fact]
        public void When_ValidateUserDto_WithValidUserDto_Then_NoExceptionThrown()
        {
            // Arrange
            var userDto = new UserDto
            {
                Id = 1,
                Name = "John Doe",
            };

            // Act and Assert
            UserDtoValidator.ValidateUserDto(userDto); // No exception should be thrown
        }

        [Fact]
        public void When_ValidateUserDto_WithNullName_Then_ThrowsUserDtoException()
        {
            // Arrange
            var userDto = new UserDto
            {
                Id = 1,
                Name = null!, // Invalid: Name is null
            };

            // Act
            var exception = Assert.Throws<UserDtoException>(() =>
            {
                UserDtoValidator.ValidateUserDto(userDto);
            });

            // Assert
            Assert.Equal("Name cannot be null or an empty string", exception.Message);
        }

        [Fact]
        public void When_ValidateUserDto_WithEmptyName_Then_ThrowsUserDtoException()
        {
            // Arrange
            var userDto = new UserDto
            {
                Id = 1,
                Name = string.Empty, // Invalid: Name is an empty string
                // Set other properties as needed...
            };

            // Act and Assert
            var exception = Assert.Throws<UserDtoException>(() =>
            {
                UserDtoValidator.ValidateUserDto(userDto);
            });

            Assert.Equal("Name cannot be null or an empty string", exception.Message);
        }

        // Add more test methods for other validation rules as needed...
    }
}
