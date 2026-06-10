using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiFinancialControl.Api.Shared.Enums;
using ApiFinancialControl.Api.Shared.Models;

namespace ApiFinancialControl.Api.Features.Api.Category.Models
{
    public class Category : BaseEntity
    {
        public Guid UserId { get; set; }
        public string Name { get; set; } = string.Empty;
        public CategoryType Type { get; set; }
        public string Color { get; set; } = string.Empty;
    }
}