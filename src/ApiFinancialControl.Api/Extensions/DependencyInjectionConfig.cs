using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiFinancialControl.Api.Data;
using ApiFinancialControl.Api.Features.Api.Users.Repositories;
using ApiFinancialControl.Api.Features.Api.Users.Services;
using Microsoft.EntityFrameworkCore;

namespace ApiFinancialControl.Api.Extensions
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection AddProjectDependencies(this IServiceCollection services)
        {

            // SERVICES
            services.AddScoped<IUserService, UserService>();

            // REPOSITORIES
            services.AddScoped<IUserRepository, UserRepository>();
            return services;
        }

        // INFERASTRUCTUR
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(
            configuration.GetConnectionString("DefaultConnection")));

            return services;
        }
    }
}