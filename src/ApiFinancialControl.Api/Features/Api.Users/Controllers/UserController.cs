using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiFinancialControl.Api.Features.Api.Users.DTOs.Create;
using ApiFinancialControl.Api.Features.Api.Users.DTOs.Response;
using ApiFinancialControl.Api.Features.Api.Users.DTOs.Update;
using ApiFinancialControl.Api.Features.Api.Users.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiFinancialControl.Api.Features.Api.Users.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UserController : ControllerBase
    {
        private readonly UserService _service;
        public UserController(UserService service) => _service = service;

        [HttpGet]
        [ProducesResponseType(typeof(List<UserResponseDTO>), 200)]
        public async Task<IActionResult> Get() => Ok(await _service.GetAll());

        [HttpGet("{id:guid}")]
        [ProducesResponseType(typeof(UserResponseDTO), 200)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetById(Guid id)
        {
            var user = await _service.GetById(id);
            if (user is null) return NotFound(user);
            return Ok(user);
        }

        [HttpPost]
        [ProducesResponseType(typeof(UserResponseDTO), 201)]
        [ProducesResponseType(400)]
        public async Task<IActionResult> Create(UserCreateDTO dto)
        {
            await _service.Create(dto);
            return CreatedAtAction("", dto);
        }

        [HttpPut("{id:guid}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> Update(Guid id, UserUpdateDTO dto)
        {
            await _service.Update(id, dto);
            return NoContent();
        }

        [HttpDelete("{id:guid}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _service.Delete(id);
            return NoContent();
        }
    }
}