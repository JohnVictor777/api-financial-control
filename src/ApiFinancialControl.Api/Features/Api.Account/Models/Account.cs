using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiFinancialControl.Api.Shared.Enums;

namespace ApiFinancialControl.Api.Features.Api.Account.Models
{
    public class Account
    {
        public Guid UserId { get; set; }
        public string Name { get; set; } = string.Empty;

        public decimal InitialBalance { get; set; }
        public decimal CurrentBalance { get; set; }

        public AccountType Type { get; set; }

        public bool IsActive { get; set; }
    }
}