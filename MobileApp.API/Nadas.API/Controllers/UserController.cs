using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Nadas.API.Business.Interfaces;
using Nadas.API.Entities.Concrete;
using Nadas.DTO.DTOs.UserDtos;

namespace Nadas.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UserController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(_mapper.Map<List<UserListDto>>(await _userService.GetAllAsync()));
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(_mapper.Map<UserListDto>(await _userService.FindById(id)));
        }

        [HttpPost]
        public async Task<IActionResult> Create(UserAddDto user)
        {
            User registeredUser = await _userService.RegisterAsync(_mapper.Map<User>(user));
            if (registeredUser == null)
                return BadRequest();
            return Created("", registeredUser);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, UserUpdateDto user)
        {
            if (id != user.Id)
                return BadRequest("");
            await _userService.UpdateAsync(_mapper.Map<User>(user));
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _userService.RemoveAsync(new User { Id = id });
            return NoContent();
        }
    }
}
