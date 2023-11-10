using Application.Dtos;
using Application.Exceptions;
using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        //private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository /*IMapper mapper*/)
        {
            _userRepository = userRepository;
            //_mapper = mapper;
        }
        public async Task<UserDto> GetUserById(int userId)
        {
            User userWeAreLookingFor = await _userRepository.GetUserById(userId);

            if (userWeAreLookingFor == null)
            {
                throw new NotFoundException($"User with ID {userId} not found.");
            }

            // Instead of this declaration we can instead map with AutoMapper...
            UserDto userToReturn = new UserDto { Id = userWeAreLookingFor.Id, Name = userWeAreLookingFor.Name };
            return userToReturn;
        }

        public Task<List<UserDto>> GetAllUsers()
        {
            throw new NotImplementedException();

        }
    }
}
