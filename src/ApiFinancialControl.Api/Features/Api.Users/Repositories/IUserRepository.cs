using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiFinancialControl.Api.Features.Api.Users.Models;

namespace ApiFinancialControl.Api.Features.Api.Users.Repositories
{
    public interface IUserRepository
    {
        Task<List<User>> GetAll();
        Task<User?> GetById(Guid id);
        Task Create(User user);
        Task Update(User user);
        Task Delete(User user);
    }
}