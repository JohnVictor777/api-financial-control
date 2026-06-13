using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiFinancialControl.Api.Shared.Enums;
using ApiFinancialControl.Api.Shared.Models;

namespace ApiFinancialControl.Api.Features.API.Transaction.Models
{
    public class Transaction : BaseEntity
    {
        public Guid AccountId { get; set; }
        public Guid CategoryId { get; set; }
        public string Description { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public TransactionType Type { get; set; }
        public DateTime TransactionDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}