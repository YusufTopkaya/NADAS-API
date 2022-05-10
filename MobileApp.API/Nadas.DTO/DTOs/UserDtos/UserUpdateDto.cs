using Nadas.DTO.Interfaces;

namespace Nadas.DTO.DTOs.UserDtos
{
    public class UserUpdateDto : IDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public bool IsVerified { get; set; }
        public int AuthLevel { get; set; }
    }
}
