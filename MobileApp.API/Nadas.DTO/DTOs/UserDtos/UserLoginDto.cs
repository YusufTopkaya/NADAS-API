using Nadas.DTO.Interfaces;

namespace Nadas.DTO.DTOs.UserDtos
{
    public class UserLoginDto : IDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
