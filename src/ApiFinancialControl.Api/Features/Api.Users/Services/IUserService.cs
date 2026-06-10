using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiFinancialControl.Api.Features.Api.Users.DTOs.Create;
using ApiFinancialControl.Api.Features.Api.Users.DTOs.Response;
using ApiFinancialControl.Api.Features.Api.Users.DTOs.Update;

namespace ApiFinancialControl.Api.Features.Api.Users.Services
{
    public interface IUserService
    {
        Task<List<UserResponseDTO>> GetAll();
        Task<UserResponseDTO?> GetById(Guid id);
        Task Create(UserCreateDTO usercreatedto);
        Task Update(Guid id, UserUpdateDTO userupdatedto);
        Task Delete(Guid id);
    }
}