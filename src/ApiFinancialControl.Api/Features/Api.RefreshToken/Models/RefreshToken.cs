using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiFinancialControl.Api.Shared.Models;

namespace ApiFinancialControl.Api.Features.Api.RefreshToken.Models
{
    public class RefreshToken : BaseEntity
    {
        public Guid UserId { get; set; }
        public Guid Token { get; set; }
        public DateTime ExpiresAt { get; set; }
        public bool IsRevoked { get; set; }
    }
}