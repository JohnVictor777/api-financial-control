using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiFinancialControl.Api.Features.Api.Users.DTOs.Create;
using ApiFinancialControl.Api.Features.Api.Users.DTOs.Response;
using ApiFinancialControl.Api.Features.Api.Users.DTOs.Update;
using ApiFinancialControl.Api.Features.Api.Users.Models;
using ApiFinancialControl.Api.Features.Api.Users.Repositories;

namespace ApiFinancialControl.Api.Features.Api.Users.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;
        public UserService(IUserRepository repository) => _repository = repository;

        public async Task<List<UserResponseDTO>> GetAll()
        {
            var users = await _repository.GetAll();

            return users.Select(u => new UserResponseDTO
            {
                Id = u.Id,
                Name = u.Name,
                Email = u.Email
            }).ToList();
        }
        public async Task<UserResponseDTO?> GetById(Guid id)
        {
            var user = await _repository.GetById(id);
            if (user == null) return null;

            return new UserResponseDTO
            {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email
            };
        }

        public async Task Create(UserCreateDTO usercreatedto)
        {
            var user = new User
            {
                Id = Guid.NewGuid(),
                Name = usercreatedto.Name,
                Email = usercreatedto.Email,
                Password = usercreatedto.Password
            };

            await _repository.Create(user);
        }

        public async Task Update(Guid id, UserUpdateDTO userupdatedto)
        {
            var user = await _repository.GetById(id);
            if (user == null)
                throw new Exception("User not found");

            user.Name = userupdatedto.Name.Trim();
            user.Email = userupdatedto.Email.Trim();
            user.Password = userupdatedto.Password?.Trim() ?? user.Password;

            await _repository.Update(user);
        }

        public async Task Delete(Guid id)
        {
            var user = await _repository.GetById(id);
            if (user == null)
                throw new Exception("User not found");

            await _repository.Delete(user);
        }
    }
}