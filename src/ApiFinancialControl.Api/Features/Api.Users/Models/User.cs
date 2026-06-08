using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiFinancialControl.Api.Shared.Models;

namespace ApiFinancialControl.Api.Features.Api.Users.Models
{
    public class User : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string? Email { get; set; }
        public string? Password { get; set; }
        public bool IsActive { get; set; }
    }
}