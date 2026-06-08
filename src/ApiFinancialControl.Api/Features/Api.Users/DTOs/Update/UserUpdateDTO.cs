using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFinancialControl.Api.Features.Api.Users.DTOs.Update
{
    public class UserUpdateDTO
    {
        [Required]
        [MaxLength(200)]
        public string? Name { get; set; }
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string? Email { get; set; }
        [MinLength(6)]
        [MaxLength(100)]
        public string? Password { get; set; }
    }
}