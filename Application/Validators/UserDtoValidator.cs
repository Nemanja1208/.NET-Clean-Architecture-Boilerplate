using Application.Dtos;
using Application.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Validators
{
    public class UserDtoValidator
    {
        public static void ValidateUserDto(UserDto userDto)
        {
            if (string.IsNullOrWhiteSpace(userDto.Name))
            {
                throw new UserDtoException("Name cannot be null or an empty string");
            }
            // Add more validation rules as needed
        }
    }
}
